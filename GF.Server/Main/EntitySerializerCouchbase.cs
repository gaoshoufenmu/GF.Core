using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Couchbase;
using Couchbase.Configuration.Client;
using Couchbase.Configuration.Client.Providers;
using Couchbase.Core;
using Couchbase.IO;
using Newtonsoft.Json;
using GF.Common;

namespace GF.Server
{
    public class EntityCouchbase
    {
        //---------------------------------------------------------------------
        public static EntityCouchbase Instance { get; private set; }
        EntityMgr EntityMgr { get; set; }
        IBucket Bucket { get; set; }

        //---------------------------------------------------------------------
        public EntityCouchbase(EntityMgr entity_mgr, IBucket bucket)
        {
            Instance = this;
            EntityMgr = entity_mgr;
            Bucket = bucket;
        }

        //---------------------------------------------------------------------
        public async Task<Entity> asyncLoadAndCreateEntity<T>(string et_guid, Dictionary<string, object> cache_data = null) where T : EntityDef
        {
            string db_key = typeof(T).Name + EntityMgr.NodeTypeAsString + "_" + et_guid;
            var op_result = await this.Bucket.GetAsync<string>(db_key);

            var et_data_str = string.Empty;

            if (op_result.Status == ResponseStatus.Success)
            {
                et_data_str = op_result.Value;
            }
            else if (op_result.Status == ResponseStatus.KeyNotFound)
            {
                et_data_str = string.Empty;
            }
            else
            {
                throw new Exception("Read from Couchbase Error: ", op_result.Exception);
            }

            if (!string.IsNullOrEmpty(et_data_str))
            {
                // 不为空
                EntityData et_data = JsonConvert.DeserializeObject<EntityData>(et_data_str);
                et_data.cache_data = cache_data;
                return EntityMgr.genEntity<T>(et_data);
            }
            else
            {
                // 为空
                return EntityMgr.genEntity<T>(cache_data);
            }
        }

        //---------------------------------------------------------------------
        public async Task<Entity> asyncLoadAndCreateEntity<T, TUserData>(string et_guid, TUserData user_data, Dictionary<string, object> cache_data = null) where T : EntityDef
        {
            string db_key = typeof(T).Name + EntityMgr.NodeTypeAsString + "_" + et_guid;
            var op_result = await this.Bucket.GetAsync<string>(db_key);

            var et_data_str = string.Empty;

            if (op_result.Status == ResponseStatus.Success)
            {
                et_data_str = op_result.Value;
            }
            else if (op_result.Status == ResponseStatus.KeyNotFound)
            {
                et_data_str = string.Empty;
            }
            else
            {
                throw new Exception("Read from Couchbase Error: ", op_result.Exception);
            }

            if (!string.IsNullOrEmpty(et_data_str))
            {
                // 不为空
                EntityData et_data = JsonConvert.DeserializeObject<EntityData>(et_data_str);
                et_data.cache_data = cache_data;
                return EntityMgr.genEntity<T, TUserData>(et_data, user_data);
            }
            else
            {
                // 为空
                return EntityMgr.genEntity<T, TUserData>(cache_data, user_data);
            }
        }

        //---------------------------------------------------------------------
        public Task asyncSaveEntity(Entity et)
        {
            var et_data = et.genEntityData4SaveDb();
            string et_data_str = JsonConvert.SerializeObject(et_data);
            string db_key = et_data.entity_type + EntityMgr.NodeTypeAsString + "_" + et_data.entity_guid;
            return Bucket.UpsertAsync(db_key, et_data_str);
        }
    }
}
