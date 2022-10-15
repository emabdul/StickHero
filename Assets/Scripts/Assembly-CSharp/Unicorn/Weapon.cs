using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public class Weapon : Buff
	{
		[SerializeField]
		private List<GameObject> listWeapons;

		[SerializeField]
		private TextMeshProUGUI powerText;

		[SerializeField]
		private DataTextureSkin DataTextureSkin;

		private MaterialPropertyBlock propBlock;

		private Transform weapon;

		private int weaponID;

		private WeaponType weaponType;

		private Tween startTween;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private IEnumerator DelayedReloadSound(WeaponType weaponType)
		{
			return null;
		}

		private void InitColor(Renderer renderer)
		{
		}

		public override void Start()
		{
		}

		public override void DoMath()
		{
		}

		public override void TriggerAnim()
		{
		}

		public override void TriggerAnimDamage()
		{
		}

		public override void TriggerEnemyAnim()
		{
		}

		public override void TriggerPlayerAnim()
		{
		}

		public override void TriggerRagdoll()
		{
		}

		private void PlayerPowerUpSound()
		{
		}

		public Weapon()
			: base()
		{
		}
	}
}
