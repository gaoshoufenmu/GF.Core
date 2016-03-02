using System;
using System.Collections.Generic;
using Eb;

public class EtSampleUCenter : EntityDef
{
    //-------------------------------------------------------------------------
    public override void declareAllComponent(byte node_type)
    {
        declareComponent<DefSampleUCenter>();
    }
}
