using System;
using System.Collections.Generic;
using Eb;
using Es;

public class EtTest : EntityDef
{
    //-------------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefTest>();
    }
}
