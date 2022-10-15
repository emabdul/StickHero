namespace UnityEngine.EventSystems.Extensions
{
	[AddComponentMenu("Event/Extensions/Aimer Input Module")]
	public class AimerInputModule : PointerInputModule
	{
		public string activateAxis;

		public Vector2 aimerOffset;

		public static GameObject objectUnderAimer;

		protected AimerInputModule()
			: base()
		{
		}

		public override void ActivateModule()
		{
		}

		public override void Process()
		{
		}

		protected virtual PointerEventData GetAimerPointerEventData()
		{
			return null;
		}

		private void ProcessInteraction(PointerEventData pointer, bool pressed, bool released)
		{
		}

		public override void DeactivateModule()
		{
		}
	}
}
