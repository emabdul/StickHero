using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Unicorn
{
	public class AnimEvents_Player : MonoBehaviour
	{
		[SerializeField]
		private PlayerController playerController;

		[SerializeField]
		private List<GameObject> ListFxAttack;

		[SerializeField]
		private List<Transform> ListFxPos;

		private LobbyManager lobbyManager;

		private Tweener tweenCoin;

		private int tmpCoin;

		public bool isGatling { get; set; }

		private void Start()
		{
		}

		public void PlayMinigunSound()
		{
		}

		public void TriggerFxGun(int fxIndex)
		{
		}

		public void TriggerFxAttack(int fxIndex)
		{
		}

		public void TriggerFxAttackPos1(int fxIndex)
		{
		}

		public void TriggerFxAttackPos2(int fxIndex)
		{
		}

		public void TriggerAttack(int fxIndex)
		{
		}

		public void FinalAttack(int fxIndex)
		{
		}

		public void SetControllable()
		{
		}

		private IEnumerator DelayControllable(bool controllable)
		{
			return null;
		}

		public void OpenChest()
		{
		}

		public void PlayFxLanding()
		{
		}

		public void PlayFxHammer()
		{
		}

		private void PlayHitSound()
		{
		}

		private bool CheckAutoTarget()
		{
			return default(bool);
		}

		private bool CheckFloor()
		{
			return default(bool);
		}

		private bool CheckFloorPrincess()
		{
			return default(bool);
		}

		private bool CheckFloorTreasure()
		{
			return default(bool);
		}

		private void SetPowerText()
		{
		}

		private void PlayFxAttack(int fxIndex, int pos)
		{
		}

		public AnimEvents_Player()
			: base()
		{
		}
	}
}
