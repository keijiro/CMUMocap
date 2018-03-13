using UnityEditor;

namespace JP.Keijiro.CMUMocap
{
    static class Selector
    {
        [MenuItem("Packages/CMU Mocap")]
        static void OpenPackageDirectory()
        {
            var path = "Packages/jp.keijiro.cmu-mocap/README.md";
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath(path);
            EditorGUIUtility.PingObject(Selection.activeObject);
        }
    }
}
