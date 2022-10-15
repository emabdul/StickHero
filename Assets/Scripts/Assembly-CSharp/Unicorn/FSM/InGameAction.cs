using Common.FSM;
using UnityEngine;

namespace Unicorn.FSM
{
	public class InGameAction : UnicornFSMAction
	{
		private LobbyManager lobbyManager;

		private Vector3 targetPos;

		private bool isEndgame;

		private UiTutorial uiTutorial;

		private Camera camera;

		public InGameAction(GameManager gameManager, FSMState owner)
			: base(gameManager, owner)
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void CheckCameraHorizontal()
		{
		}

		private void CheckCameraVertical()
		{
		}

		private void CheckTower()
		{
		}

		private void CheckTowerVertical()
		{
		}

		private void CheckEndgame()
		{
		}

		private void UpdateTutorial()
		{
		}

		private void UpdateTutLvl1()
		{
		}

		private void UpdateTutLvl2()
		{
		}

		public override void OnExit()
		{
		}

		private bool CheckAllEnemyDead()
		{
			return default(bool);
		}
	}
}
