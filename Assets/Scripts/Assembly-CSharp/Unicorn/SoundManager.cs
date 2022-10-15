using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace Unicorn
{
	[Singleton("SoundManager", true)]
	public class SoundManager : Singleton<SoundManager>
	{
		public enum GameSound
		{
			BGM = 0,
			Footstep = 1,
			Spin = 2,
			Lobby = 3,
			ClockTick = 4,
			RewardClick = 5,
			IGM = 6,
			EmptyAttack = 7,
			AxeAttack = 8,
			DaggerAttack = 9,
			HammerAttack = 10,
			SwordAttack = 11,
			BossAttack = 12,
			AxeGet = 13,
			DaggerGet = 14,
			HammerGet = 15,
			SwordGet = 16,
			Die = 17,
			BossDie = 18,
			BigBossDie = 19,
			ChangeSize = 20,
			Grab = 21,
			GrabRelease = 22,
			GirlTwerk = 23,
			GirlWin = 24,
			GirlLose = 25,
			GirlWinLoop = 26,
			BrothelLoop = 27,
			OpenChest = 28,
			Coin = 29,
			ShopPurchase = 30,
			TrapBear = 31,
			TrapSaw = 32,
			PowerUp = 33,
			BlueDie = 34,
			BlueAttack = 35,
			GreenDie = 36,
			GreenAttack = 37,
			PurpleDie = 38,
			PurpleAttack = 39,
			OrangeDie = 40,
			OrangeAttack = 41,
			Key = 42,
			GateOpen = 43,
			TowerBreak = 44,
			Handgun = 45,
			Minigun = 46,
			Rifle = 47,
			Shotgun = 48,
			Reload_Handgun = 49,
			Reload_Minigun = 50,
			Reload_Rifle = 51,
			Reload_Shotgun = 52,
			Diamond = 53
		}

		[SerializeField]
		public SoundData soundData;

		public AudioMixer audioMixer;

		public AudioSource bgMusic;

		public AudioSource fxSound;

		public AudioSource fxSoundFootStep;

		public AudioSource clockTickFast;

		public AudioSource coffinSource;

		private float bgVol;

		private bool isPlayFootStep;

		private int lastIndex;

		public bool IsOnVibration
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		public void PlayFxSound(Enum soundEnum)
		{
		}

		public void PlayFxSound(Enum soundEnum, AudioSource audioSource)
		{
		}

		public void StopSound(Enum soundEnum)
		{
		}

		public void SettingFxSound(bool isOn)
		{
		}

		public void SettingMusic(bool isOn)
		{
		}

		private void PlayFxSound(AudioClip clip, AudioSource audioSource)
		{
		}

		private void PlayBGM(int index)
		{
		}

		private void PlayBGM(AudioClip audioClip)
		{
		}

		private void PlayClockTick(AudioClip clip)
		{
		}

		private void PlayFxSound(AudioClip clip)
		{
		}

		private void StopFxSound()
		{
		}

		public void PlayCoffinTheme(bool isPlaying, float delay = 0f)
		{
		}

		public void PlaySoundButton()
		{
		}

		public void PlaySoundSpin()
		{
		}

		public void PlaySoundRevive()
		{
		}

		public void PlaySoundReward()
		{
		}

		public void PlaySoundStartCrewmate()
		{
		}

		public void PlaySoundStartImpostor()
		{
		}

		public void PlaySoundWinCrewmate()
		{
		}

		public void PlaySoundWinImposter()
		{
		}

		public void PlaySoundCollectible(TypeSoundIngame typeSound)
		{
		}

		public void PlayFootStep()
		{
		}

		public void StopFootStep()
		{
		}

		public void PlaySoundOverTime()
		{
		}

		public SoundManager()
			: base()
		{
		}
	}
}
