using UnityEngine;

namespace Pspkurara.Singleton{

	/// <summary>
	/// シングルトンなモノビヘイビア.
	/// </summary>
	[DisallowMultipleComponent]
	public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour{

		static T m_Instance;
		/// <summary>
		/// シングルトンなインスタンスを返す.
		/// </summary>
		public static T instance{
			get{
				SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath);
				return m_Instance;
			}}

		static string m_InstancePath = null;

		/// <summary>
		/// シングルトン名インスタンスが存在しているかを返す.
		/// </summary>
		/// <param name="raw">厳密に現在検索済みのデータでチェック</param>
		/// <returns>存在している</returns>
		public static bool GetHasInstance(bool raw = false){
			if (raw) return GetHasInstance();
			SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath, true);
			return m_Instance != null;
		}

		/// <summary>
		/// 存在しなかった際に自動生成対象とするプレハブ参照のパスを設定する.
		/// staticコンストラクタ等<see cref="instance"/>にアクセスする前にのみ呼び出すこと.
		/// </summary>
		/// <param name="resourcesLoadPath"><see cref="Resources.Load(string)"/>のパス</param>
		protected static void SetInstancePath(string resourcesLoadPath){
			m_InstancePath = resourcesLoadPath;
		}

		/// <summary>
		/// 手動で起動する
		/// </summary>
		public static void Activate()
		{
			SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath);
		}
		
	}

	/// <summary>
	/// シングルトンなモノビヘイビア.
	/// instanceは内部もち.
	/// </summary>
	[DisallowMultipleComponent]
	public abstract class InternalSingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour{

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

		/// <summary>
		/// 手動で起動する
		/// </summary>
		public static void Activate()
		{
			SingletonUtilitiy.GetInstance(ref m_Instance, m_InstancePath);
		}

	}

}