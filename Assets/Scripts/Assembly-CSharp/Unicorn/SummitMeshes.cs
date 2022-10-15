using System.Collections.Generic;
using UnityEngine;

namespace Unicorn
{
	public class SummitMeshes : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> listMeshes;

		[SerializeField]
		private GameObject summit;

		public void Explode(Vector3 pos)
		{
		}

		public SummitMeshes()
			: base()
		{
		}
	}
}
