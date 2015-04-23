using UnityEngine;
using System.Collections;

public class addForceOnTriggerEnterAxe : MonoBehaviour {

	public ForceMode forceMode;
	public float forceStrength = 20.0f;
	public float radius = 0.5f;
	public float upwardsModifier = 0.0f;

	void OnTriggerEnter (Collider other) 
	{
		if(other.attachedRigidbody)
		{
			other.attachedRigidbody.AddForceAtPosition (transform.forward,transform.position,forceMode);
		}
		Destroy (gameObject);
	}
}

