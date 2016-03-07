using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

public class EditorGfInternal : EditorWindow
{
    //-------------------------------------------------------------------------
    [MenuItem("Gf/导出GfCore.unitypackage")]
    static void exportGfCorePackage()
    {
        string[] arr_assetpathname = new string[2];
        arr_assetpathname[0] = "Assets/GfCore";
        arr_assetpathname[1] = "Assets/Plugins/GfUnity";
        AssetDatabase.ExportPackage(arr_assetpathname, "GfCore.unitypackage", ExportPackageOptions.Recurse);

        Debug.Log("Export GfCore.unitypackage Finished!");
    }

    //-------------------------------------------------------------------------
    [MenuItem("Gf/导出GfJson.unitypackage")]
    static void exportGfJsonPackage()
    {
        string[] arr_assetpathname = new string[1];
        arr_assetpathname[0] = "Assets/Plugins/GfJson";
        AssetDatabase.ExportPackage(arr_assetpathname, "GfJson.unitypackage", ExportPackageOptions.Recurse);

        Debug.Log("Export GfJson.unitypackage Finished!");
    }
}
