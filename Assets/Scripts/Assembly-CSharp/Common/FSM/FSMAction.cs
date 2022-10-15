namespace Common.FSM
{
	public class FSMAction
	{
		private readonly FSMState owner;

		public FSMAction(FSMState owner)
			: base()
		{
		}

		public FSMState GetOwner()
		{
			return null;
		}

		public virtual void OnEnter()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnLateUpdate()
		{
		}

		public virtual void OnFixedUpdate()
		{
		}

		public virtual void OnExit()
		{
		}
	}
}
