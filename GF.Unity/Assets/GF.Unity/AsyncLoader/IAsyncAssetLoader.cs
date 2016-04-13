using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public abstract class IAsyncAssetLoader
{
    //-------------------------------------------------------------------------    
    public string AssetPath { get; set; }
    public Dictionary<AsyncAssetLoadGroup, List<RequestLoadAssetInfo>> MapRequestLoadAssetInfo { get; set; }

    //-------------------------------------------------------------------------
    public IAsyncAssetLoader() { }

    //-------------------------------------------------------------------------
    public abstract void createAssetLoad(string asset_path, string asset_name, AsyncAssetLoadGroup async_assetloadgroup, Action<UnityEngine.Object> loaded_action);

    ////-------------------------------------------------------------------------
    //public abstract void cancelAssetLoad(UnityEngine.Object canel_object);

    //-------------------------------------------------------------------------
    public abstract void checkAssetLoadDone();

    //-------------------------------------------------------------------------
    public abstract string assetLoadError();

    //-------------------------------------------------------------------------
    internal abstract void destoryAssetLoad();

    //-------------------------------------------------------------------------
    internal abstract void assetLoadDone();
}

//-------------------------------------------------------------------------
public class RequestLoadAssetInfo
{
    public string AssetName { get; set; }
    //public bool IsCancel { get; set; }
    public Action<UnityEngine.Object> LoadedAction { get; set; }
}
