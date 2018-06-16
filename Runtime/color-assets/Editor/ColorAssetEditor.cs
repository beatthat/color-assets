using BeatThat.Pools;
using BeatThat.Properties;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace BeatThat.ColorAssets
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(ColorAsset), true)]
	public class ColorAssetEditor : UnityEditor.Editor
	{
		override public void OnInspectorGUI()
		{
			EditorGUI.BeginChangeCheck ();
			base.OnInspectorGUI ();
			if (EditorGUI.EndChangeCheck ()) {
				using (var users = ListPool<IHasColorAsset>.Get ()) {
					FindAll<IHasColorAsset> (users);
					foreach (var u in users) {
						u.OnColorAssetUpdated (this.target as ColorAsset);
					}
				}
			}
		}

		private static void FindAll<T>(List<T> objects) where T : class
		{
			foreach(Object o in Object.FindObjectsOfType(typeof(Component))) {
				var t = o as T;
				if(t != null) {
					objects.Add (t);
				}
			}
		}
	}
}



