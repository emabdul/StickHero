using System.Collections;

namespace UnityEngine.UI.Extensions
{
	public class CardStack2D : MonoBehaviour
	{
		[SerializeField]
		private float cardMoveSpeed;

		[SerializeField]
		private float buttonCooldownTime;

		[SerializeField]
		private int cardZMultiplier;

		[SerializeField]
		private bool useDefaultUsedXPos;

		[SerializeField]
		private int usedCardXPos;

		[SerializeField]
		private Transform[] cards;

		private int cardArrayOffset;

		private Vector3[] cardPositions;

		private int xPowerDifference;

		public static bool canUseHorizontalAxis;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private IEnumerator ButtonCooldown()
		{
			return null;
		}

		public CardStack2D()
			: base()
		{
		}
	}
}
