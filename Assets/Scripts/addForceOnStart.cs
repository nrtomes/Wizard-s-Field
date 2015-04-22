using UnityEngine;
using System.Collections;

public class addForceOnStart : MonoBehaviour
{
	public float force = 100.0f;
	public ForceMode forceMode;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody>().AddForce(transform.forward*force,forceMode);
	}
}
