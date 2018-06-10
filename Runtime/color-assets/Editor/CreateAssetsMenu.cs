using BeatThat.Properties;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace BeatThat
{
	public static class CreateAssetsMenu 
	{

		[MenuItem("Assets/Create/Ape - ColorBlock", false, 100)]
		public static void CreateColorBlock()
		{
			CreateAsset<ColorBlockAsset>();
		}

		[MenuItem("Assets/Create/Ape - Gradient", false, 100)]
		public static void CreateGradient()
		{
			CreateAsset<GradientAsset>();
		}

		[MenuItem("Assets/Create/Ape - Color", false, 100)]
		public static void CreateColor()
		{
			CreateAsset<ColorAsset>();
		}

		public static T CreateAsset<T>() where T : ScriptableObject
		{
			var dirPath = "Assets";
			foreach (Object obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets)) {
				dirPath = AssetDatabase.GetAssetPath(obj);
				if (File.Exists(dirPath)) {
					dirPath = Path.GetDirectoryName(dirPath);
				}
				break;
			}

			string fileName = typeof(T).Name;
			int i = 0;
			T asset = null;
			while((asset = AssetDatabase.LoadAssetAtPath(Path.Combine(dirPath, fileName+ ".asset"), typeof(T)) as T) != null) {
				fileName = string.Format("{0}{1}", typeof(T).Name, (++i));
			}

			asset = ScriptableObject.CreateInstance<T>();
			AssetDatabase.CreateAsset(asset, Path.Combine(dirPath, fileName+ ".asset"));

			EditorUtility.SetDirty(asset);
			AssetDatabase.SaveAssets();

			AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(asset));  

			return asset;
		}

	}
}
