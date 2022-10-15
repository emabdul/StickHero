using Common.FSM;

namespace Unicorn.FSM
{
	public class EndgameAction : UnicornFSMAction
	{
		public EndgameAction(GameManager gameManager, FSMState owner)
			: base(gameManager, owner)
		{
		}

		public override void OnEnter()
		{
		}

		private void ProcessWinLose()
		{
		}

		public override void OnExit()
		{
		}
	}
}
