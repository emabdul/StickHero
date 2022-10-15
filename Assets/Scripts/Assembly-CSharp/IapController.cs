using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

public class IapController : MonoBehaviour, IStoreListener
{
	[SerializeField]
	private DataShopIap data;

	[SerializeField]
	private List<InAppProduct> productList;

	private int numPack;

	public Action<IdPack, bool> EventPurchaseSuccess;

	private IStoreController m_Controller;

	private IAppleExtensions m_AppleExtensions;

	private IMicrosoftExtensions m_MicrosoftExtensions;

	private ITransactionHistoryExtensions m_TransactionHistoryExtensions;

	private IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;

	private const string lincenseKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAt2M0VamyC0bsFIN9KX29ts1P6Ab8LVcToyBbBxHs3rIu1eSUrlj8GSn2Bl4jWuMgDgDNTvk4KO9XuIqnPJSrWBOoi65LT86lirncrGSg6aiAp/jr/Wo35SgvXvOnJhtIDIBbduQGnNGIJTl8lukO8NzeL/TVAEvRPrUym8joGdWiQ/kgjFS2aAUG8V9cs3IAt9hzPwCCCMVuGcU9ZMe0rC/kOtWVFgg3DsRIOkNvkZEXzsNw0ZJZ9g2lqon9VXPzxZh7Bj085n7qF1SrXeQ3BGnQcGuDF/gephGLI+35G8/OkVH0d05GbDI6EgKQK1sL9rDPOJcq3qOJ5Bw+GLKA7wIDAQAB";

	private bool m_IsGooglePlayStoreSelected;

	private bool m_IsSamsungAppsStoreSelected;

	private bool m_PurchaseInProgress;

	public List<InAppProduct> ProductList
	{
		get
		{
			return null;
		}
	}

	public DataShopIap Data
	{
		get
		{
			return null;
		}
	}

	public Dictionary<IdPack, InfoPrice> DictInfoPricePack { get; private set; }

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(Product item, PurchaseFailureReason r)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void Awake()
	{
	}

	private void OnTransactionsRestored(bool success)
	{
	}

	private void OnDeferred(Product item)
	{
	}

	public void PurchaseProduct(int id)
	{
	}

	public void RestoreButtonClick()
	{
	}

	private bool NeedRestoreButton()
	{
		return default(bool);
	}

	private void LogProductDefinitions()
	{
	}

	private string GetIDPack(int index)
	{
		return null;
	}

	private void GetAllPricePackage()
	{
	}

	private ProductMetadata GetProductMetadata(string sku)
	{
		return null;
	}

	private void SetItemBuySuccessed(IdPack _idPack)
	{
	}

	private void SetRewardPurchase(DataElementGift reward, string analytic = "iap")
	{
	}

	private void LogTracking(float gPrice, string gCurrency, Product product)
	{
	}

	public IapController()
		: base()
	{
	}
}
