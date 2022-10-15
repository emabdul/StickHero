using UnityEngine;

public interface IFloor
{
	Transform CalculatePlayerSpawnPos();

	void OnBlockEnter();

	void OnBlockExit();
}
