using UnityEditor;
using UnityEngine;
using System.Diagnostics;

public class BuildEditor 
{
	[MenuItem("MyTools/BuildExecute")]
	public static void BuildExecute ()
	{
		UnityEngine.Debug.Log ("build");

		EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.WebPlayer );
		string[] allScene = new string[EditorBuildSettings.scenes.Length];
		int i = 0;
		foreach( EditorBuildSettingsScene scene in EditorBuildSettings.scenes ){
			allScene[i] = scene.path;
			i++;
		}
		
		string errorMsg_Device = BuildPipeline.BuildPlayer(allScene,
		                                                   "./StandaloneWindows64.exe",
								                          BuildTarget.StandaloneWindows,
		                                                   BuildOptions.None
		                         );

		if (string.IsNullOrEmpty(errorMsg_Device)){
			
		} else {
			//エラー処理適当に		
		}
	}
}