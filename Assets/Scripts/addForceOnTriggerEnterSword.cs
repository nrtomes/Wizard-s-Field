using UnityEngine;
using System.Collections;

public class addForceOnTriggerEnterSword: MonoBehaviour {

	public ForceMode forceMode;
	public float forceStrength = 20.0f;
	public float radius = 0.5f;
	public float upwardsModifier = 0.0f;
	public bool isAttacking = false;

	void OnTriggerEnter (Collider other) 
	{
		if(isAttacking)
		{
			other.attachedRigidbody.AddExplosionForce (forceStrength, transform.position, radius, upwardsModifier, forceMode);
		}
	}
}
