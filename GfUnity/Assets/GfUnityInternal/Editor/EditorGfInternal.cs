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
    [MenuItem("Gf/导出GfUnity.unitypackage")]
    static void exportGf4UnityPackage()
    {
        string[] arr_assetpathname = new string[2];
        arr_assetpathname[0] = "Assets/GfUnity";
        arr_assetpathname[1] = "Assets/Plugins";
        AssetDatabase.ExportPackage(arr_assetpathname, "GfUnity.unitypackage", ExportPackageOptions.Recurse);

        Debug.Log("Export GfUnity.unitypackage Finished!");
    }
}
