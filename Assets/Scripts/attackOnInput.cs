using UnityEngine;
using System.Collections;

public class attackOnInput : MonoBehaviour 
{
	public string attackPrimary = "Fire1";
	public bool isAttacking = false;
	public bool useForceOnImpact = false;

	public ForceMode forceMode;
	public float forceStrength = 20.0f;
	public float radius = 0.5f;
	public float upwardsModifier = 0.0f;

	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton (attackPrimary))
		{
			animator.SetBool ("isAttacking", true);
		}
		else
		{
			animator.SetBool ("isAttacking", isAttacking);
		}
	}

	void OnTriggerEnter (Collider other) 
	{
		if(isAttacking && useForceOnImpact)
		{
			other.attachedRigidbody.AddExplosionForce (forceStrength, transform.position, radius, upwardsModifier, forceMode);
		}
	}
}
