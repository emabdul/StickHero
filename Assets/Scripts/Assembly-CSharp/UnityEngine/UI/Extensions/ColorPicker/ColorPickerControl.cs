using System.Collections.Generic;

namespace UnityEngine.UI.Extensions.ColorPicker
{
	[ExecuteInEditMode]
	public class ColorPickerControl : MonoBehaviour
	{
		private float _hue;

		private float _saturation;

		private float _brightness;

		private float _red;

		private float _green;

		private float _blue;

		private float _alpha;

		public ColorChangedEvent onValueChanged;

		public HSVChangedEvent onHSVChanged;

		[SerializeField]
		private bool hsvSlidersOn;

		[SerializeField]
		private List<GameObject> hsvSliders;

		[SerializeField]
		private bool rgbSlidersOn;

		[SerializeField]
		private List<GameObject> rgbSliders;

		[SerializeField]
		private GameObject alphaSlider;

		public Color CurrentColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float H
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float S
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float V
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float R
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float G
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float B
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private float A
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public void SetHSVSlidersOn(bool value)
		{
		}

		public void SetRGBSlidersOn(bool value)
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}

		private void RGBChanged()
		{
		}

		private void HSVChanged()
		{
		}

		private void SendChangedEvent()
		{
		}

		public void AssignColor(ColorValues type, float value)
		{
		}

		public float GetValue(ColorValues type)
		{
			return default(float);
		}

		public ColorPickerControl()
			: base()
		{
		}
	}
}
