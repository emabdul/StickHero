using System.Runtime.CompilerServices;
using Common.FSM;
using Unicorn.FSM;

namespace Unicorn
{
	public class GameFSM : Common.FSM.FSM
	{
		private FSMState waitGameState;

		private FSMState lobbyGameState;

		private LobbyAction lobbyGameAction;

		private FSMState inGameState;

		private InGameAction inGameAction;

		private FSMState endGameState;

		private EndgameAction endGameAction;

		private FSMState reviveGameState;

		private ReviveAction reviveGameAction;

		private FSMState preparationState;

		public GameState CurrentGameState { get; private set; }

		public FSMState LobbyGameState
		{
			get
			{
				return null;
			}
		}

		public FSMState WaitGameState
		{
			get
			{
				return null;
			}
		}

		public FSMState InGameState
		{
			get
			{
				return null;
			}
		}

		public FSMState EndGameState
		{
			get
			{
				return null;
			}
		}

		public FSMState ReviveGameState
		{
			get
			{
				return null;
			}
		}

		public FSMState PreparationState
		{
			get
			{
				return null;
			}
		}

		public GameFSM(GameManager gameController)
			: base(default(System.String))
		{
		}

		public void ChangeState(GameState state)
		{
		}
	}
}
