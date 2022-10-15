using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class MainMenuManager : MonoBehaviour
	{
		[SerializeField]
		private Camera camera;

		[SerializeField]
		private float cameraSize;

		[SerializeField]
		private SkinChangerStick skinChanger;

		public static MainMenuManager Instance;

		private Camera tempCam;

		public SkinChangerStick SkinChanger
		{
			get
			{
				return null;
			}
		}

		public int CameraIndex { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateCamera()
		{
		}

		private void SetUpCamera()
		{
		}

		public MainMenuManager()
			: base()
		{
		}
	}
}
