using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class BreakableTower : MonoBehaviour
	{
		[SerializeField]
		private List<Collider> listBreakables;

		[SerializeField]
		private List<Collider> listHorizontalBreakables;

		[SerializeField]
		private List<Collider> listVerticalRightBreakables;

		public bool isLast;

		public List<Collider> ListBreakables
		{
			get
			{
				return null;
			}
		}

		public List<Collider> ListHorizontalBreakables
		{
			get
			{
				return null;
			}
		}

		public List<Collider> ListVerticalRightBreakables
		{
			get
			{
				return null;
			}
		}

		public bool IsTriggered { get; set; }

		private void Start()
		{
		}

		public void TurnOnIsTrigger()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private IEnumerator DisableMeshes()
		{
			return null;
		}

		public BreakableTower()
			: base()
		{
		}
	}
}
