using Common.FSM;

namespace Unicorn.FSM
{
	public class LobbyAction : UnicornFSMAction
	{
		private LobbyManager lobbyManager;

		public LobbyAction(GameManager gameManager, FSMState owner)
			: base(gameManager, owner)
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}
	}
}
