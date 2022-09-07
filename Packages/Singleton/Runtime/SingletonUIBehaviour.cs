#if SINGLETON_UGUI_SUPPORT

using UnityEngine;
using UnityEngine.EventSystems;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンなUIビヘイビア.
	/// </summary>
	public abstract class SingletonUIBehaviour<T> : UIBehaviour where T : UIBehaviour{
	
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		public static T instance{
			get{
				SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = typeof(T).Name;

		/// <summary>
		/// 存在しなかった際に自動生成対象とするプレハブ参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// </summary>
		/// <param name="resourcesLoadPath"><see cref="Resources.Load(string)"/>のパス</param>
		protected static void SetInstancePath(string resourcesLoadPath){
			m_InstancePath = resourcesLoadPath;
		}
		
	}

	/// <summary>
	/// シングルトンなUIビヘイビア.
	/// </summary>
	public abstract class InternalSingletonUIBehaviour<T> : UIBehaviour where T : UIBehaviour{
	
		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		protected static T instance{
			get{
				SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = typeof(T).Name;

		/// <summary>
		/// 存在しなかった際に自動生成対象とするプレハブ参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// </summary>
		/// <param name="resourcesLoadPath"><see cref="Resources.Load(string)"/>のパス</param>
		protected static void SetInstancePath(string resourcesLoadPath){
			m_InstancePath = resourcesLoadPath;
		}
		
	}

}

#endif
