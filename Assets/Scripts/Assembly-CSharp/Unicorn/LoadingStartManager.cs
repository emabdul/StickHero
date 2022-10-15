using System.Collections;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class LoadingStartManager : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup group;

		[SerializeField]
		private Image imgLoading;

		[SerializeField]
		private float timeLoading;

		private AsyncOperation loadSceneAsync;

		private AppOpenAdManager appOpenAdManager;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LoadAppOpen()
		{
		}

		private void LoadMasterLevel()
		{
		}

		private void RunLoadingBar()
		{
		}

		private IEnumerator Fade()
		{
			return null;
		}

		public void OnApplicationPause(bool paused)
		{
		}

		public LoadingStartManager()
			: base()
		{
		}
	}
}
