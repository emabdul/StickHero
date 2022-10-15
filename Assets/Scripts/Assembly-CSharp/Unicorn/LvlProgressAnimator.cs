using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class LvlProgressAnimator : MonoBehaviour
	{
		[SerializeField]
		private Image[] images;

		[SerializeField]
		private List<Sprite> listSpriteTall;

		[SerializeField]
		private List<Sprite> listSpriteShort;

		private Tween activeTween;

		public Image ActiveImage { get; set; }

		public void Init()
		{
		}

		public void InitAnimation()
		{
		}

		public void InitTowerSprites()
		{
		}

		public LvlProgressAnimator()
			: base()
		{
		}
	}
}
