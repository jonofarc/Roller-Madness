using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(InitializePreferences))]
public class DeletePreferences : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		InitializePreferences myScript = (InitializePreferences)target;
		if(GUILayout.Button("Delete Preferences (Reset First Time Use)"))
		{
			myScript.DeletePreferences ();
		}
	}
}
