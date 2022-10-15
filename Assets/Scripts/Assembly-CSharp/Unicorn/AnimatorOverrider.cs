using UnityEngine;

namespace Unicorn
{
	public class AnimatorOverrider : MonoBehaviour
	{
		[SerializeField]
		private Animator playerAnim;

		public void SetAnimators(AnimatorOverrideController animatorOverrideController)
		{
		}

		public AnimatorOverrider()
			: base()
		{
		}
	}
}
