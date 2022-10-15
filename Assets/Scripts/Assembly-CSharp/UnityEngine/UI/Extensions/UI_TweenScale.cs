using System.Collections;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/UI Tween Scale")]
	public class UI_TweenScale : MonoBehaviour
	{
		public AnimationCurve animCurve;

		[Tooltip("Animation speed multiplier")]
		public float speed;

		[Tooltip("If true animation will loop, for best effect set animation curve to loop on start and end point")]
		public bool isLoop;

		[Tooltip("If true animation will start automatically, otherwise you need to call Play() method to start the animation")]
		public bool playAtAwake;

		[Space]
		[Header("Non uniform scale")]
		[Tooltip("If true component will scale by the same amount in X and Y axis, otherwise use animCurve for X scale and animCurveY for Y scale")]
		public bool isUniform;

		public AnimationCurve animCurveY;

		private Vector3 initScale;

		private Transform myTransform;

		private Vector3 newScale;

		private void Awake()
		{
		}

		public void Play()
		{
		}

		private IEnumerator Tween()
		{
			return null;
		}

		public void ResetTween()
		{
		}

		public UI_TweenScale()
			: base()
		{
		}
	}
}
