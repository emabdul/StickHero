using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


[Singleton("GameService", true)]
public class GameService : Singleton<GameService>
{
	//private VerifyFirebase firebaseReady;

	//public bool FirebaseInitialized;

	public bool IsLoadRemoteConfigSucces;

	private void Start()
	{
	}

	private void InitData()
	{
	}

	private IEnumerator InitFirebase()
	{
		return null;
	}

	private void InitializeFirebase()
	{
	}

	public GameService()
		: base()
	{
	}
}
