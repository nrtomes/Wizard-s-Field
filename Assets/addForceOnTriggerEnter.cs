using UnityEngine;
using System.Collections;

public class addForceOnTriggerEnter : MonoBehaviour {

	public ForceMode forceMode;
	public float forceStrength = 20.0f;
	public float radius = 0.5f;
	public float upwardsModifier = 0.0f;

	void OnTriggerEnter (Collider other) 
	{
		other.attachedRigidbody.AddExplosionForce (forceStrength, transform.position, radius, upwardsModifier, forceMode);
	}
}
