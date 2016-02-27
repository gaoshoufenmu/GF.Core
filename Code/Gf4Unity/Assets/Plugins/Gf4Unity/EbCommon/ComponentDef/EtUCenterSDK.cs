using System;
using System.Collections.Generic;
using Eb;

public class EtUCenterSDK : EntityDef
{
    //-------------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefUCenterSDK>();
    }
}
