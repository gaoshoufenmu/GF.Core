using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

public class EditorInternal : EditorWindow
{
    //-------------------------------------------------------------------------
    [MenuItem("Gf/导出Gf4Unity.unitypackage")]
    static void exportGf4UnityPackage()
    {
        string[] arr_assetpathname = new string[2];
        arr_assetpathname[0] = "Assets/Gf4Unity";
        arr_assetpathname[1] = "Assets/Plugins";
        AssetDatabase.ExportPackage(arr_assetpathname, "Gf4Unity.unitypackage", ExportPackageOptions.Recurse);

        Debug.Log("Export Gf4Unity.unitypackage Finished!");
    }
}
