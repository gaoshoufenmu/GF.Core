using System;
using System.Collections.Generic;
using GF.Common;
using GF.Server;

public class EtTest : EntityDef
{
    //-------------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefTest>();
    }
}
