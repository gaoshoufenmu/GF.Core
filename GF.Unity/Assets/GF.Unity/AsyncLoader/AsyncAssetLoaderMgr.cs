using System;
using System.Collections.Generic;

public class AsyncAssetLoaderMgr
{
    //-------------------------------------------------------------------------
    static AsyncAssetLoaderMgr mAsyncAssetLoaderMgr;
    Dictionary<string, IAsyncAssetLoader> mMapIAsyncAssetLoader;
    Dictionary<string, IAsyncAssetLoader> mMapNeedRemoveAssetLoader;

    //-------------------------------------------------------------------------
    private AsyncAssetLoaderMgr()
    {
        mMapIAsyncAssetLoader = new Dictionary<string, IAsyncAssetLoader>();
        mMapNeedRemoveAssetLoader = new Dictionary<string, IAsyncAssetLoader>();
    }

    //-------------------------------------------------------------------------
    public static AsyncAssetLoaderMgr Instant
    {
        get
        {
            if (mAsyncAssetLoaderMgr == null)
            {
                mAsyncAssetLoaderMgr = new AsyncAssetLoaderMgr();
            }

            return mAsyncAssetLoaderMgr;
        }
    }

    //-------------------------------------------------------------------------
    public void update(float time)
    {
        foreach (var i in mMapIAsyncAssetLoader)
        {
            i.Value.checkAssetLoadDone();
        }

        foreach (var i in mMapNeedRemoveAssetLoader)
        {
            if (mMapIAsyncAssetLoader.ContainsKey(i.Key))
            {
                mMapIAsyncAssetLoader.Remove(i.Key);
            }
        }

        mMapNeedRemoveAssetLoader.Clear();
    }

    //-------------------------------------------------------------------------
    public AsyncAssetLoadGroup createAsynAssetLoader(_eAsyncAssetLoadType async_assetloadtype, string asset_path,
        string asset_name, Action<UnityEngine.Object> loaded_action, AsyncAssetLoadGroup async_assetloadgroup = null)
    {
        if (async_assetloadgroup == null)
        {
            async_assetloadgroup = new AsyncAssetLoadGroup();
        }

        IAsyncAssetLoader asynce_assetloader = null;
        mMapIAsyncAssetLoader.TryGetValue(asset_path, out asynce_assetloader);
        if (asynce_assetloader == null)
        {
            switch (async_assetloadtype)
            {
                case _eAsyncAssetLoadType.WWW:
                    asynce_assetloader = new WWWAsyncAssetLoader();
                    break;
                case _eAsyncAssetLoadType.LoacalAB:
                    asynce_assetloader = new LocalABAsyncAssetLoader();
                    break;
                default:
                    break;
            }
        }

        asynce_assetloader.createAssetLoad(asset_path, asset_name, async_assetloadgroup, loaded_action);

        mMapIAsyncAssetLoader[asset_path] = asynce_assetloader;

        return async_assetloadgroup;
    }

    ////-------------------------------------------------------------------------
    //public void cancelAsyncAssetLoader(string asset_path, UnityEngine.Object canel_object)
    //{
    //    if (mMapIAsyncAssetLoader.ContainsKey(asset_path))
    //    {
    //        mMapIAsyncAssetLoader[asset_path].cancelAssetLoad(canel_object);
    //    }
    //}

    //-------------------------------------------------------------------------
    public void destroyAsyncAssetLoader(string asset_path)
    {
        if (mMapIAsyncAssetLoader.ContainsKey(asset_path))
        {
            mMapNeedRemoveAssetLoader[asset_path] = mMapIAsyncAssetLoader[asset_path];
            //mMapIAsyncAssetLoader.Remove(asset_path);
        }
    }
}

//-------------------------------------------------------------------------
public enum _eAsyncAssetLoadType
{
    WWW,
    LoacalAB,
}