using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class SkinChangerStick : MonoBehaviour
	{
		[SerializeField]
		private DataTextureSkin dataTextureSkin;

		[SerializeField]
		private GameObject headGO;

		[SerializeField]
		private List<GameObject> listHeads;

		[SerializeField]
		private List<Renderer> listHeadRenderer;

		[SerializeField]
		private List<Renderer> playerRenderers;

		[SerializeField]
		private List<ArmorPieces> listArmors;

		[SerializeField]
		private List<GameObject> listWeapons;

		private MaterialPropertyBlock propBlock;

		public ArmorPieces CurrentArmor { get; set; }

		public GameObject CurrentHead { get; set; }

		public GameObject CurrentWeapon { get; set; }

		public List<GameObject> ListWeapons
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListHeads
		{
			get
			{
				return null;
			}
		}

		public List<ArmorPieces> ListArmors
		{
			get
			{
				return null;
			}
		}

		public DataTextureSkin DataTextureSkin
		{
			get
			{
				return null;
			}
		}

		public List<Renderer> PlayerRenderers
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void InitMPB()
		{
		}

		public void Init()
		{
		}

		public void InitChallenge()
		{
		}

		private void ChangeRenderersColor(Color color)
		{
		}

		private void ChangeRenderersColorChallenge(Color color)
		{
		}

		private void ChangeSkin(int id)
		{
		}

		public void ChangeWeapon(int id)
		{
		}

		public void ChangeArmor(int id)
		{
		}

		public void ChangeHead(int id)
		{
		}

		public void Change(TypeEquipment typeEquipment, int id)
		{
		}

		public SkinChangerStick()
			: base()
		{
		}
	}
}
