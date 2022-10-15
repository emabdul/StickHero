using UnityEngine;

namespace Unicorn
{
	public abstract class SkinChanger : MonoBehaviour
	{
		public abstract void Init();

		public abstract void Change(TypeEquipment typeEquipment, int id);

		public SkinChanger()
			: base()
		{
		}
	}
}
