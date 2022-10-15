using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unicorn.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class UiChallengeSwipe : UICanvas
	{
		[SerializeField]
		private Transform content;

		[SerializeField]
		private Scrollbar scrollBar;

		[SerializeField]
		private GameObject itemPrefab;

		[SerializeField]
		private Button btnNext;

		[SerializeField]
		private Button btnPrev;

		[SerializeField]
		private Button btnPlay;

		[SerializeField]
		private Button btnUnlock;

		[SerializeField]
		private Button btnCantUnlock;

		[SerializeField]
		private Button btnClose;

		[SerializeField]
		private TextMeshProUGUI coinText;

		[SerializeField]
		private TextMeshProUGUI cantUnlockText;

		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private TextMeshProUGUI gemText;

		[SerializeField]
		private HorizontalLayoutGroup towerGroup;

		[SerializeField]
		private HorizontalLayoutGroup thumbnailGroup;

		[SerializeField]
		private List<GameObject> listTowers;

		[SerializeField]
		private List<ChallengeLevelInfo> listChallengeInfo;

		private float scroll_pos;

		private float[] pos;

		private int currentIndex;

		public int displayLevel { get; set; }

		public bool isShowAd { get; set; }

		public Transform Content
		{
			get
			{
				return null;
			}
		}

		public List<ChallengeLevelInfo> ListChallengeInfo
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListTowers
		{
			get
			{
				return null;
			}
		}

		public List<ChallengeItem> ListChallengeItems { get; set; }

		private new void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateInformation()
		{
		}

		private void UpdateNumberOfTowers()
		{
		}

		private void UpdateButtonPlayUnlock()
		{
		}

		private void UpdateButtonNextPrev()
		{
		}

		private void Init()
		{
		}

		private void InitItem()
		{
		}

		public void OnClickBtnNext()
		{
		}

		public void OnClickBtnPrev()
		{
		}

		private void OnClickBtnPlay()
		{
		}

		private void OnClickBtnUnlock()
		{
		}

		private void OnClickBtnClose()
		{
		}

		private void OnRewardVideo(int x)
		{
		}

		public UiChallengeSwipe()
			: base()
		{
		}
	}
}
