using System.Collections;
using UnityEngine;

namespace Unicorn
{
	public class ChallengeEnemy : MonoBehaviour
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private AnimatorOverrider animatorOverrider;

		[SerializeField]
		private AnimatorOverrideController listAnimOverride;

		public Animator Animator
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		private IEnumerator ScreamIdling()
		{
			return null;
		}

		private void TriggerAnimScare()
		{
		}

		public ChallengeEnemy()
			: base()
		{
		}
	}
}
