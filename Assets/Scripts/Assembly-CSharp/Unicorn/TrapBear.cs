using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public class TrapBear : Trap
	{
		[SerializeField]
		private Transform left;

		[SerializeField]
		private Transform right;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private TextMeshProUGUI powerText;

		private new void Start()
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

		private IEnumerator DelayResult()
		{
			return null;
		}

		public override void TriggerPlayerAnim()
		{
		}

		public override void TriggerRagdoll()
		{
		}

		public TrapBear()
			: base()
		{
		}
	}
}
