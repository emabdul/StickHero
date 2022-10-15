using System;
using System.Runtime.CompilerServices;
using Common.FSM;

namespace Unicorn.FSM
{
	public abstract class UnicornFSMAction : FSMAction
	{
		protected GameManager GameManager { get; }

		protected UnicornFSMAction(GameManager gameManager, FSMState owner)
			: base(owner)
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public event Action Entered;

		public event Action Exited;
	}
}
