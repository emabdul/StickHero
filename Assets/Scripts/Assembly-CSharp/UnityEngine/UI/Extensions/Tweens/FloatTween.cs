using UnityEngine.Events;

namespace UnityEngine.UI.Extensions.Tweens
{
	public struct FloatTween : ITweenValue
	{
		public class FloatTweenCallback : UnityEvent<float>
		{
			public FloatTweenCallback()
				: base()
			{
			}
		}

		public class FloatFinishCallback : UnityEvent
		{
			public FloatFinishCallback()
				: base()
			{
			}
		}

		private float m_StartFloat;

		private float m_TargetFloat;

		private float m_Duration;

		private bool m_IgnoreTimeScale;

		private FloatTweenCallback m_Target;

		private FloatFinishCallback m_Finish;

		public float startFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float targetFloat
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool ignoreTimeScale
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void TweenValue(float floatPercentage)
		{
		}

		public void AddOnChangedCallback(UnityAction<float> callback)
		{
		}

		public void AddOnFinishCallback(UnityAction callback)
		{
		}

		public bool GetIgnoreTimescale()
		{
			return default(bool);
		}

		public float GetDuration()
		{
			return default(float);
		}

		public bool ValidTarget()
		{
			return default(bool);
		}

		public void Finished()
		{
		}
	}
}
