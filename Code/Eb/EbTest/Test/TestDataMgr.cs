using System;
using System.Collections.Generic;
using System.Text;

namespace Eb
{
    class TestDataMgr : Test
    {
        //---------------------------------------------------------------------
        EbDataMgr mDataMgr = new EbDataMgr();

        //---------------------------------------------------------------------
        public override void init()
        {
            string db_filename = "..\\..\\..\\Media\\EbTest\\Config\\test.bytes";
            //"..\\..\\..\\Media\\EbTest\\Config\\Dragon.db";
            mDataMgr.setup("Dragon", db_filename);
        }

        //---------------------------------------------------------------------
        public override void release()
        {
        }

        //---------------------------------------------------------------------
        public override void update()
        {
        }
    }
}
