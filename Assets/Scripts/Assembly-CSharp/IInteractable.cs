using UnityEngine;

public interface IInteractable
{
	int Power { get; set; }

	Floor ParentFloor { get; set; }

	Animator Anim { get; set; }

	MathOperator ArithmeticOperator { get; set; }

	InteractableType InteractableType { get; set; }

	void DoMath();

	void TriggerAnim();

	void TriggerPlayerAnim();

	void TriggerEnemyAnim();

	void TriggerAnimDamage();

	void TriggerRagdoll();
}
