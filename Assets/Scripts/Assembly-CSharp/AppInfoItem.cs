using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AppInfoItem : MonoBehaviour
{
	public enum State
	{
		None = 0,
		Loading = 1,
		Playing = 2
	}

	public GameObject gAds;

	public RawImage Icon;

	public Text Name;

	public Text Des;

	private PromotionConfig config;

	private VideoPlayer videoPlayer;

	private TypeMoreGamePanel typeMoreGamePanel;

	private string RocketPromoVersionKey
	{
		get
		{
			return null;
		}
	}

	private int Version
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public State nowState { get; private set; }

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	public void LoadInfo(PromotionConfig info, TypeMoreGamePanel _typeMoreGamePanel)
	{
	}

	private void LoadData()
	{
	}

	private IEnumerator LoadImage()
	{
		return null;
	}

	private void OnLoadImageComplete(Texture2D texture)
	{
	}

	private IEnumerator PlayVideo()
	{
		return null;
	}

	private void OnVideoReady(VideoPlayer vp)
	{
	}

	public void OnOpenButtonClick()
	{
	}

	public AppInfoItem()
		: base()
	{
	}
}
