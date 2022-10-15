using System;
using UnityEngine.UI.Extensions.Tweens;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Accordion/Accordion Element")]
	public class AccordionElement : Toggle
	{
		[SerializeField]
		private float m_MinHeight;

		private Accordion m_Accordion;

		private RectTransform m_RectTransform;

		private LayoutElement m_LayoutElement;

		[NonSerialized]
		private readonly TweenRunner<FloatTween> m_FloatTweenRunner;

		protected AccordionElement()
			: base()
		{
		}

		protected override void Awake()
		{
		}

		public void OnValueChanged(bool state)
		{
		}

		protected float GetExpandedHeight()
		{
			return default(float);
		}

		protected void StartTween(float startFloat, float targetFloat)
		{
		}

		protected void SetHeight(float height)
		{
		}
	}
}
