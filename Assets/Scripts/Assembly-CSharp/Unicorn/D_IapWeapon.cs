using System.Collections.Generic;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class D_IapWeapon : ScriptableObject
	{
		public List<int> ListWeaponIdPending;

		public int numberFreeWeaponLeft;

		public List<int> ListWeaponIdForInit;

		public List<int> ListWeaponId;

		public D_IapWeapon()
			: base()
		{
		}
	}
}
