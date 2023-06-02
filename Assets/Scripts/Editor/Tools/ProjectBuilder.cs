using System.Linq;
using UnityEditor;
using UnityEngine;

internal static class ProjectBuilder
{
    [MenuItem("Tools/Build")]
    public static void Build()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();

        options.target = EditorUserBuildSettings.activeBuildTarget;

        string suffix = string.Empty;
        switch (options.target)
        {
            case BuildTarget.StandaloneWindows:
                suffix = "exe";
                break;
            case BuildTarget.StandaloneWindows64:
                suffix = "exe";
                break;
            case BuildTarget.Android:
                suffix = "apk";
                break;
            default:
                return;
        }

        options.locationPathName = $"{Application.dataPath}/../Output/{PlayerSettings.bundleVersion}/{options.target}/{PlayerSettings.productName}.{suffix}";
        options.scenes = EditorBuildSettings.scenes.Select(s => s.path).ToArray();

        //EditorUserBuildSettings.development = true;

        BuildPipeline.BuildPlayer(options);
    }
}