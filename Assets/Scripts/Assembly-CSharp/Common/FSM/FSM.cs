using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Common.FSM
{
	public class FSM
	{
		private delegate void StateActionProcessor(FSMAction action);

		private readonly string name;

		public FSMState currentState;

		private readonly Dictionary<int, FSMState> stateMap;

		public string Name
		{
			get
			{
				return null;
			}
		}

		private void ProcessStateAction(FSMState state, StateActionProcessor actionProcessor)
		{
		}

		public FSMState AddState(int name)
		{
			return null;
		}

		public FSM(string name)
			: base()
		{
		}

		public void Start(int stateId)
		{
		}

		public void ChangeToState(FSMState state)
		{
		}

		public void EnterState(FSMState state)
		{
		}

		private void ExitState(FSMState state)
		{
		}

		public void Update()
		{
		}

		public void LateUpdate()
		{
		}

		public void FixedUpdate()
		{
		}

		public void SendEvent(int eventId)
		{
		}

		public int GetCurrentState()
		{
			return default(int);
		}

		private FSMState ResolveTransition(int eventId)
		{
			return null;
		}
	}
}
