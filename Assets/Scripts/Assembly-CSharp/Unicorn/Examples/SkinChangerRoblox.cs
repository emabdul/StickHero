using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn.Examples
{
	public class SkinChangerRoblox : SkinChanger
	{
		public static readonly int MAIN_COLOR_ID;

		public static readonly int EMISSION_MAP_ID;

		public static readonly int EMISSION_COLOR;

		public static readonly int MAIN_TEXTURE_ID;

		[SerializeField]
		private bool canHavePet;

		[SerializeField]
		protected DataTextureSkin dataTextureSkin;

		[SerializeField]
		private Renderer[] renderers;

		[SerializeField]
		private Vector3 petOffset;

		[SerializeField]
		private float petMaxDistance;

		private Transform maskTransform;

		private GameObject mask;

		private MeshRenderer faceRenderer;

		private Transform hatTransform;

		private GameObject hat;

		private Pet pet;

		private Character character;

		private MaterialPropertyBlock blockMaterial;

		public DataTextureSkin DataTextureSkin
		{
			get
			{
				return null;
			}
		}

		public Renderer[] Renderers
		{
			get
			{
				return null;
			}
		}

		public int TypeSkin { get; protected set; }

		public int TypeHat { get; private set; }

		public int Number { get; private set; }

		public int PetId { get; private set; }

		public Pet Pet
		{
			get
			{
				return null;
			}
		}

		private MaterialPropertyBlock BlockMaterial
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public override void Init()
		{
		}

		public virtual void Init(Character character)
		{
		}

		private void InitFace()
		{
		}

		private void InitSkin()
		{
		}

		private void InitHat()
		{
		}

		private void InitMask()
		{
		}

		private void InitPet()
		{
		}

		public override void Change(TypeEquipment typeEquipment, int id)
		{
		}

		public void CopyFrom(SkinChangerRoblox skinChangerRoblox)
		{
		}

		public virtual void ChangeSkin(int id)
		{
		}

		public void ChangeNumber(int num)
		{
		}

		public void ChangeToWinTexture()
		{
		}

		public void ChangeToDieTexture()
		{
		}

		public virtual void ChangeTexture(Renderer renderer, Texture texture, int materialId = 0)
		{
		}

		public virtual void ChangeHat(int id)
		{
		}

		public virtual void ChangePet(int id)
		{
		}

		private void ChangeMask(int id)
		{
		}

		public SkinChangerRoblox()
			: base()
		{
		}

		public event Action<SkinChangerRoblox, Pet> OnNewPetSpawned;
	}
}
