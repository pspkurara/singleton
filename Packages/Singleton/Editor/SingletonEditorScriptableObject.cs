using UnityEngine;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンなスクリプタブルオブジェクト.
	/// エディタ専用.
	/// </summary>
	public abstract class InternalSingletonEditorScriptableObject<T> : ScriptableObject where T : ScriptableObject {
	
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		protected static T instance{
			get{
				EditorSingletonUtilitiy.GetScriptable(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = null;

		/// <summary>
		/// インスタンス参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// 初期値は自動的に全アセットを検索して最初に見つかったものを使用する.
		/// </summary>
		/// <param name="assetPath"><see cref="AssetDatabase.LoadAssetAtPath{T}(string)"/>のパス</param>
		protected static void SetInstancePath(string assetPath){
			m_InstancePath = assetPath;
		}
		
	}

	/// <summary>
	/// シングルトンなスクリプタブルオブジェクト.
	/// エディタ専用.
	/// </summary>
	public abstract class SingletonEditorScriptableObject<T> : ScriptableObject where T : ScriptableObject {
		
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		public static T instance{
			get{
				EditorSingletonUtilitiy.GetScriptable(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = null;

		/// <summary>
		/// インスタンス参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// 初期値は自動的に全アセットを検索して最初に見つかったものを使用する.
		/// </summary>
		/// <param name="assetPath"><see cref="AssetDatabase.LoadAssetAtPath{T}(string)"/>のパス</param>
		protected static void SetInstancePath(string assetPath){
			m_InstancePath = assetPath;
		}

	}

}