using System.Collections;
using Unicorn.UI;
using UnityEngine;

namespace Unicorn
{
	public class LevelTransition : UICanvas
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private float transitionTime;

		public void OpenCastle()
		{
		}

		public void LoadScene(bool isLoadLevel)
		{
		}

		public void LoadChallenge(int buildIndex)
		{
		}

		private IEnumerator LoadBuildIndex(int buildIndex)
		{
			return null;
		}

		private IEnumerator LoadNextScene()
		{
			return null;
		}

		private IEnumerator LoadMenu()
		{
			return null;
		}

		private IEnumerator LoadCastle()
		{
			return null;
		}

		public LevelTransition()
			: base()
		{
		}
	}
}
