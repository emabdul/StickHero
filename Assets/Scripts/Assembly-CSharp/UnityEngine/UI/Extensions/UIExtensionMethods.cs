namespace UnityEngine.UI.Extensions
{
	public static class UIExtensionMethods
	{
		public static Canvas GetParentCanvas(this RectTransform rt)
		{
			return null;
		}

		public static Vector2 TransformInputBasedOnCanvasType(this Vector2 input, Canvas canvas)
		{
			return default(Vector2);
		}

		public static Vector3 TransformInputBasedOnCanvasType(this Vector2 input, RectTransform rt)
		{
			return default(Vector3);
		}

		public static Camera GetEventCamera(this Canvas input)
		{
			return null;
		}
	}
}
