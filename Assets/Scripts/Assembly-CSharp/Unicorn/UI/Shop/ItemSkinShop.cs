using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI.Shop
{
	public class ItemSkinShop : MonoBehaviour
	{
		[SerializeField]
		private TypeEquipment typeEquipment;

		[SerializeField]
		protected Image icon;

		[SerializeField]
		protected List<Button> listBtnBehavior;

		[SerializeField]
		private Button btnView;

		[SerializeField]
		protected Text txtVideo;

		[SerializeField]
		private Text txtCoin;

		[SerializeField]
		private Text txtGem;

		[SerializeField]
		private Sprite[] spriteBackgrounds;

		protected DataShop dataShop;

		protected ShopCharacter shopCharacter;

		private IDataSkin playerData;

		private bool isAwakeCalled;

		protected Image ImgBg { get; set; }

		public TypeEquipment TypeEquipment
		{
			get
			{
				return default(TypeEquipment);
			}
		}

		private void Awake()
		{
		}

		public virtual void Init(DataShop data, ShopCharacter shopCharacter)
		{
		}

		private void InitUnlocked()
		{
		}

		private void InitLocked()
		{
		}

		protected virtual void OnClickBtnView()
		{
		}

		protected virtual void OnClickBtnBehaviour(int idBehaviour)
		{
		}

		private void OnRewardedVideo(int x)
		{
		}

		private void Apply(bool isApply = true)
		{
		}

		public ItemSkinShop()
			: base()
		{
		}
	}
}
