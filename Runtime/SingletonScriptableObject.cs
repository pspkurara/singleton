using UnityEngine;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンなスクリプタブルオブジェクト.
	/// </summary>
	public abstract class InternalSingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject {
	
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		protected static T instance{
			get{
				SingletonUtilitiy.GetScriptable(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = typeof(T).Name;

		/// <summary>
		/// インスタンス参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// 初期値は"<see cref="Resources"/>のルート/<see cref="T"/>の型名"となっている.
		/// </summary>
		/// <param name="resourcesLoadPath"><see cref="Resources.Load(string)"/>のパス</param>
		protected static void SetInstancePath(string resourcesLoadPath){
			m_InstancePath = resourcesLoadPath;
		}
		
	}
	
	/// <summary>
	/// シングルトンなスクリプタブルオブジェクト.
	/// </summary>
	public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject {
		
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		public static T instance{
			get{
				SingletonUtilitiy.GetScriptable(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = typeof(T).Name;

		/// <summary>
		/// インスタンス参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// 初期値は"<see cref="Resources"/>のルート/<see cref="T"/>の型名"となっている.
		/// </summary>
		/// <param name="resourcesLoadPath"><see cref="Resources.Load(string)"/>のパス</param>
		protected static void SetInstancePath(string resourcesLoadPath){
			m_InstancePath = resourcesLoadPath;
		}

	}

}