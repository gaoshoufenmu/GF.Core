using System;
using System.Collections.Generic;

public class AsyncAssetLoadGroup
{
    //-------------------------------------------------------------------------
    public bool IsCancel { get; private set; }

    //-------------------------------------------------------------------------
    public AsyncAssetLoadGroup()
    {
        IsCancel = false;
    }

    //-------------------------------------------------------------------------
    public void cancelAsyncAssetLoad()
    {
        IsCancel = true;
    }
}
