using UnityEngine;

namespace Unicorn.Utilities
{
	public class PresetPositioner : MonoBehaviour
	{
		public Vector3 presetPosition;

		public Quaternion presetRotation;

		public Vector3 presetScale;

		public bool canSet;

		public bool isLocally;

		public void OnEnable()
		{
		}

		public void SetPosition()
		{
		}

		public PresetPositioner()
			: base()
		{
		}
	}
}
