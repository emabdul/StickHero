using System.Collections.Generic;

namespace Common.FSM
{
	public class FSMState
	{
		private readonly int id;

		private readonly FSM owner;

		private readonly Dictionary<int, FSMState> transitionMap;

		private List<FSMAction> actions;

		public FSMState(int id, FSM owner)
			: base()
		{
		}

		public void AddTransition(int id, FSMState destinationState)
		{
		}

		public FSMState GetTransition(int eventId)
		{
			return null;
		}

		public void AddAction(FSMAction action)
		{
		}

		public bool RemoveAction(FSMAction action)
		{
			return default(bool);
		}

		public List<FSMAction> GetActions()
		{
			return null;
		}

		public void SendEvent(int eventId)
		{
		}

		internal int GetId()
		{
			return default(int);
		}
	}
}
