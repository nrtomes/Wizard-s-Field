using UnityEngine;
using System.Collections;

public class rangedAttackOnInput : MonoBehaviour {
	public GameObject prefab;
	public GameObject attackingcamera;
	public GameObject player;
	public GameObject objectSpawnLocation;
	public string rangedAttackButton = "Fire2";

	private Quaternion objectRotation;
	private float x = 0.0f;
	private float y = 0.0f;
	private float z = 0.0f;

	void Update () {
		if(Input.GetButtonDown (rangedAttackButton))
		{
			x=attackingcamera.transform.rotation.eulerAngles.x;
			y=player.transform.rotation.eulerAngles.y;
			objectRotation = Quaternion.Euler (x,y,z);
			
			Instantiate (prefab, objectSpawnLocation.transform.position, objectRotation);
		}
	}
}
