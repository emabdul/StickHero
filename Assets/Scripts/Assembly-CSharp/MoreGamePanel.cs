using System;
using System.Runtime.CompilerServices;
using Unicorn.UI;
using UnityEngine;

public class MoreGamePanel : UICanvas
{
	[SerializeField]
	private AppInfoItem[] listGames;

	private static AppPromotion data;

	private const string RocketPromoJsonCacheKey = "RocketPromoJsonCache";

	[SerializeField]
	private string PromoteDefault;

	[SerializeField]
	private TypeMoreGamePanel type;

	public float timeToLoadPromo;

	private string RocketPromoJsonCache
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool IntenetAvaiable
	{
		get
		{
			return default(bool);
		}
	}

	protected void Start()
	{
	}

	private void OnLoadAdData(string jsonData)
	{
	}

	private void HandleData()
	{
	}

	public void OnClickBack()
	{
	}

	public MoreGamePanel()
		: base()
	{
	}
}
