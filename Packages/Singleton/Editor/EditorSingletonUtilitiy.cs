using UnityEngine;
using UnityEditor;
using System.Linq;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンのための関数等.
	/// </summary>
	internal static class EditorSingletonUtilitiy{
		
		/// <summary>
		/// シングルトンが空のときにインスタンスを探して代入.
		/// </summary>
		public static void GetScriptable<T>(ref T current, string assetPath) where T : ScriptableObject{
			if(current == null){
				if(!string.IsNullOrEmpty(assetPath)){
					current = AssetDatabase.LoadAssetAtPath<T>(assetPath);
				}
				if(current != null) return;
				string[] guidList = AssetDatabase.FindAssets("t:" + typeof(T));
				if(guidList.Length == 0) return;
				string path = AssetDatabase.GUIDToAssetPath(guidList[0]);
				current = AssetDatabase.LoadAssetAtPath<T>(path);
			}
		}
		
	}

}