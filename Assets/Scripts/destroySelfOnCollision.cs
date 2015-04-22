using UnityEngine;
using System.Collections;

public class destroySelfOnCollision : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		Destroy (gameObject);
	}

}
