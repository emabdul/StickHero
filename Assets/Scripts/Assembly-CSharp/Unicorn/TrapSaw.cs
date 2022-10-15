using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public class TrapSaw : Trap
	{
		[SerializeField]
		private TextMeshProUGUI powerText;

		[SerializeField]
		private Transform saw;

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

		public TrapSaw()
			: base()
		{
		}
	}
}
