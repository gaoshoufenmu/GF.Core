using System;
using System.Collections.Generic;
using System.Text;

namespace Eb
{
    class TestEntity : Test
    {
        //---------------------------------------------------------------------
        EntityMgr mEntityMgr = null;

        //---------------------------------------------------------------------
        public override void init()
        {
            EbLog.Note("TestEntity.init()");

            if (mEntityMgr == null)
            {
                mEntityMgr = new EntityMgr(1, "");
            }
        }

        //---------------------------------------------------------------------
        public override void release()
        {
            if (mEntityMgr != null)
            {
                mEntityMgr.destroy();
                mEntityMgr = null;
            }

            EbLog.Note("TestEntity.release()");
        }

        //---------------------------------------------------------------------
        public override void update()
        {
            if (mEntityMgr != null)
            {
                mEntityMgr.update(0.1f);
            }
        }
    }
}
