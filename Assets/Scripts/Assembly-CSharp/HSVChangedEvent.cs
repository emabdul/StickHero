using UnityEngine.Events;

public class HSVChangedEvent : UnityEvent<float, float, float>
{
	public HSVChangedEvent()
		: base()
	{
	}
}
