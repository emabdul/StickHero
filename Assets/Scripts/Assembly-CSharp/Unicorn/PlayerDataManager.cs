using System;
using System.Collections.Generic;
using Unicorn.UI.Shop;
using UnityEngine;

namespace Unicorn
{
	public class PlayerDataManager : MonoBehaviour, IDataSkin
	{
		public static PlayerDataManager Instance;

		public Action<TypeItem> actionUITop;

		public DataTexture DataTexture;

		public DataTextureSkin DataTextureSkin;

		public DataRewardEndGame DataRewardEndGame;

		public DataLuckyWheel DataLuckyWheel;

		private IDataLevel unicornDataLevel;

		private Dictionary<int, float> redLightTimes;

		private List<int> listIdSkin;

		private void Awake()
		{
		}

		public void SetBundlePurchased(IdPack IdPack, bool isPurchased = true)
		{
		}

		public bool GetBundlePurchased(IdPack IdPack)
		{
			return default(bool);
		}

		public bool GetUnlockWeapon(int id)
		{
			return default(bool);
		}

		public void SetUnlockWeapon(int id)
		{
		}

		public void SetWeaponUnlockedCount(int count)
		{
		}

		public int GetWeaponUnlockedCount()
		{
			return default(int);
		}

		public void SetFirstTimeInitTower(int towerId)
		{
		}

		public bool GetFirstTimeInitTower(int towerId)
		{
			return default(bool);
		}

		public void SetCurrentTower(int towerId)
		{
		}

		public int GetCurrentTower()
		{
			return default(int);
		}

		public void SetUnLockTower(int towerId, bool isUnlocked)
		{
		}

		public bool GetUnlockTower(int towerId)
		{
			return default(bool);
		}

		public void SetCustomerTimer(int towerId, int floorId, int pos, float time)
		{
		}

		public float GetCustomerTimer(int towerId, int floorId, int pos)
		{
			return default(float);
		}

		public void SetCustomerPosition(int towerId, int floorId, int pos, bool isOccupied)
		{
		}

		public bool GetCustomerPosition(int towerId, int floorId, int pos)
		{
			return default(bool);
		}

		public void SetCustomerQuantity(int quantity)
		{
		}

		public int GetCustomerQuantity()
		{
			return default(int);
		}

		public void SetGirlQuantity(int quantity)
		{
		}

		public int GetGirlQuantity()
		{
			return default(int);
		}

		public bool GetFirstTimeBrothelPlayerTut()
		{
			return default(bool);
		}

		public void SetFirstTimeBrothelPlayerTut()
		{
		}

		public void SetChangedToScriptable()
		{
		}

		public bool GetChangedToScriptable()
		{
			return default(bool);
		}

		public void SetFirstTimeBrothel()
		{
		}

		public bool GetFirstTimeBrothel()
		{
			return default(bool);
		}

		public void SetSecondTimeBrothel()
		{
		}

		public bool GetSecondTimeBrothel()
		{
			return default(bool);
		}

		public void SetOriginalCoin(int towerId, int floorId, int coin)
		{
		}

		public int GetOriginalCoin(int towerId, int floorId)
		{
			return default(int);
		}

		public void SetOriginalGem(int towerId, int floorId, int gem)
		{
		}

		public int GetOriginalGem(int towerId, int floorId)
		{
			return default(int);
		}

		public void SetCoinToUnlock(int towerId, int floorId, int coin)
		{
		}

		public int GetCoinToUnlock(int towerId, int floorId)
		{
			return default(int);
		}

		public void SetGemToUnlock(int towerId, int floorId, int gem)
		{
		}

		public int GetGemToUnlock(int towerId, int floorId)
		{
			return default(int);
		}

		public void SetUnlockType(int towerId, int floorId, BrothelRoomUnlockType unlockType)
		{
		}

		public int GetUnlockType(int towerId, int floorId)
		{
			return default(int);
		}

		public void SetUnlockRoom(int towerId, int floorId, bool unlock)
		{
		}

		public bool GetUnlockRoom(int towerId, int floorId)
		{
			return default(bool);
		}

		public void SetPositionOccupied(int towerId, int floorId, int pos, bool isOccupied)
		{
		}

		public bool GetPositionOccupied(int towerId, int floorId, int pos)
		{
			return default(bool);
		}

		public void SetGirlType(int towerId, int floorId, int pos, BrothelGirlType girlType)
		{
		}

		public BrothelGirlType GetGirlType(int towerId, int floorId, int pos)
		{
			return default(BrothelGirlType);
		}

		public void SetCustomerType(int towerId, int floorId, int pos, CustomerType customerType)
		{
		}

		public CustomerType GetCustomerType(int towerId, int floorId, int pos)
		{
			return default(CustomerType);
		}

		public void SetFirstTime(int firstTime)
		{
		}

		public int GetFirstTime()
		{
			return default(int);
		}

		public void SetDataLevel(IDataLevel unicornDataLevel)
		{
		}

		public IDataLevel GetDataLevel(LevelConstraint levelConstraint)
		{
			return null;
		}

		public int GetMaxLevelReached()
		{
			return default(int);
		}

		public bool GetUnlockSkin(TypeEquipment type, int id)
		{
			return default(bool);
		}

		public void SetUnlockSkin(TypeEquipment type, int id)
		{
		}

		public int GetIdEquipSkin(TypeEquipment type)
		{
			return default(int);
		}

		public void SetIdEquipSkin(TypeEquipment type, int id)
		{
		}

		public int GetVideoSkinCount(TypeEquipment type, int id)
		{
			return default(int);
		}

		public void SetVideoSkinCount(TypeEquipment type, int id, int number)
		{
		}

		public int GetGold()
		{
			return default(int);
		}

		public void SetGold(int _count)
		{
		}

		public int GetGem()
		{
			return default(int);
		}

		public void SetGem(int _count)
		{
		}

		public int GetKey()
		{
			return default(int);
		}

		public void SetKey(int _count)
		{
		}

		public int GetCurrentIndexRewardEndGame()
		{
			return default(int);
		}

		public void SetCurrentIndexRewardEndGame(int index)
		{
		}

		public int GetProcessReceiveRewardEndGame()
		{
			return default(int);
		}

		public void SetProcessReceiveRewardEndGame(int number)
		{
		}

		public int GetNumberWatchDailyVideo()
		{
			return default(int);
		}

		public void SetNumberWatchDailyVideo(int number)
		{
		}

		public bool GetFreeSpin()
		{
			return default(bool);
		}

		public void SetFreeSpin(bool isFree)
		{
		}

		public int GetNumberWatchVideoSpin()
		{
			return default(int);
		}

		public void SetNumberWatchVideoSpin(int count)
		{
		}

		public string GetTimeLoginSpinFreeWheel()
		{
			return null;
		}

		public void SetTimeLoginSpinFreeWheel(string time)
		{
		}

		public void SetIsGetGem(bool isGetGem)
		{
		}

		public bool GetIsGetGem()
		{
			return default(bool);
		}

		public string GetTimeLoginSpinVideo()
		{
			return null;
		}

		public void SetTimeLoginSpinVideo(string time)
		{
		}

		public string GetTimeLoginChallenge(int buildIndexChallenge)
		{
			return null;
		}

		public void SetTimeLoginChallenge(string time, int buildIndexChallenge)
		{
		}

		public void SetSoundSetting(bool isOn)
		{
		}

		public bool GetSoundSetting()
		{
			return default(bool);
		}

		public void SetVibrateSetting(bool isOn)
		{
		}

		public bool GetVibrateSetting()
		{
			return default(bool);
		}

		public void SetMusicSetting(bool isOn)
		{
		}

		public bool GetMusicSetting()
		{
			return default(bool);
		}

		public bool IsNoAds()
		{
			return default(bool);
		}

		public void SetNoAds()
		{
		}

		public int GetIdSkinOtherPlayer()
		{
			return default(int);
		}

		public void ClearListIdSkin()
		{
		}

		public void SetNumberPlay(int num)
		{
		}

		public int GetNumberPlay()
		{
			return default(int);
		}

		public string GetTimeLoginOpenGift()
		{
			return null;
		}

		public void SetTimeLoginOpenGift(string time)
		{
		}

		public PlayerDataManager()
			: base()
		{
		}
	}
}
