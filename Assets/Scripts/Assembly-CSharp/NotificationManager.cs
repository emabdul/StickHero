using Unity.Notifications.Android;
using UnityEngine;

public class NotificationManager : Singleton<NotificationManager>
{
	private const string CHANNEL_LUCKY = "channel_lucky";

	private const string CHANNEL_OPEN_APP = "channel_open_app";

	private int identifierSpin;

	private int identifierOpenApp;

	private AndroidNotificationChannel luckyChanel;

	private AndroidNotificationChannel openAppChanel;

	[SerializeField]
	private DataNotification data;

	private void Start()
	{
	}

	private void InitNotiChanel()
	{
	}

	public void SendNotiLuckyWheel()
	{
	}

	public void SendNotiOpenApp()
	{
	}

	public NotificationManager()
		: base()
	{
	}
}
