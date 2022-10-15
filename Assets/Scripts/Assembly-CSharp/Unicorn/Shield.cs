using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public class Shield : Buff
	{
		[SerializeField]
		private TextMeshProUGUI powerText;

		[SerializeField]
		private List<Transform> listTransform;

		[SerializeField]
		private List<Renderer> ListRenderers;

		[SerializeField]
		private DataTextureSkin DataTextureSkin;

		private MaterialPropertyBlock propBlock;

		private Tween startTween;

		private int index;

		private void Awake()
		{
		}

		public override void Start()
		{
		}

		public override void DoMath()
		{
		}

		public override void TriggerAnim()
		{
		}

		public override void TriggerAnimDamage()
		{
		}

		public override void TriggerEnemyAnim()
		{
		}

		public override void TriggerPlayerAnim()
		{
		}

		public override void TriggerRagdoll()
		{
		}

		public Shield()
			: base()
		{
		}
	}
}
