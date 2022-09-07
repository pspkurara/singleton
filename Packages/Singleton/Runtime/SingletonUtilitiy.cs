using UnityEngine;
using System.Linq;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンのための関数等.
	/// </summary>
	internal static class SingletonUtilitiy{
	
		/// <summary>
		/// シングルトンが空のときにインスタンスを探して代入.
		/// </summary>
		public static void GetInstance<T>(ref T current, string path, bool isNonCreate = false) where T : MonoBehaviour{
			if(current == null){
				current = Object.FindObjectOfType<T>();
				if (isNonCreate) return;
				if(current != null) return;
				if (!string.IsNullOrEmpty(path))
				{
					GameObject loadedPrefab = Resources.Load<GameObject>(path);
					if(loadedPrefab != null){ 
						GameObject go = Object.Instantiate(loadedPrefab, Vector3.zero, Quaternion.identity);
						current = go.GetComponentInChildren<T>(true);
					}
				}
				if (current != null) return;
				GameObject create = new GameObject(typeof(T).Name);
				current = create.AddComponent<T>();
			}
		}
		
		/// <summary>
		/// シングルトンが空のときにインスタンスを探して代入.
		/// </summary>
		public static void GetScriptable<T>(ref T current, string path) where T : ScriptableObject{
			if(current == null){
				current = Resources.Load<T>(path);
			}
		}
		
	}

}