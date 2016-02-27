using System;
using System.Collections.Generic;
using Eb;

public class EtNode : EntityDef
{
    //---------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefNode>();
    }
}
