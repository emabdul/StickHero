using System.Collections.Generic;
using UnityEngine;

public class ReliableOnTriggerExit : MonoBehaviour
{
	public delegate void _OnTriggerExit(Collider c);

	private Collider thisCollider;

	private bool ignoreNotifyTriggerExit;

	private Dictionary<GameObject, _OnTriggerExit> waitingForOnTriggerExit;

	public static void NotifyTriggerEnter(Collider c, GameObject caller, _OnTriggerExit onTriggerExit)
	{
	}

	public static void NotifyTriggerExit(Collider c, GameObject caller)
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void CallCallbacks()
	{
	}

	public ReliableOnTriggerExit()
		: base()
	{
	}
}
