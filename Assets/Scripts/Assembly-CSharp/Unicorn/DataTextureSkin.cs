using System.Collections.Generic;
using Sirenix.OdinInspector;
using Unicorn.Examples;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class DataTextureSkin : SerializedScriptableObject
	{
		public List<Sprite> skinIcons;

		public List<Color> skinColors;

		public List<Texture> numberTextures;

		public List<Texture> faceTextures;

		public Texture winTexture;

		public Texture loseTexture;

		public MeshRenderer faceRenderer;

		public List<Sprite> armorIcons;

		public int[] armorId;

		public List<Sprite> hatIcons;

		public int[] headId;

		public List<Sprite> weaponIcons;

		public int[] weaponId;

		public List<Sprite> petIcons;

		public Pet[] pets;

		public Sprite GetIcon(TypeEquipment typeEquipment, int id)
		{
			return null;
		}

		public DataTextureSkin()
			: base()
		{
		}
	}
}
