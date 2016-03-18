using System;
using System.Collections.Generic;
using Eb;

public class EtSuperSocket : EntityDef
{
    //---------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefSuperSocket>();
    }
}
