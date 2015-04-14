using UnityEngine;
using System.Collections;

public class mouseLookOnAxisInput : MonoBehaviour {

	public string verticalAxis = "VerticalLook";
	public float baseRotationSpeed = 3.0f;
	public float sensitivityMultiplier = 1.0f;
	public bool invertVerticalAxis = false;
	public float flipVerticalAxis = -1.0f;
	public float verticalLimitMax = 85.0f;
	public float verticalLimitMin = -85.0f;
	public float smoothTime = 3.0f;

	private Quaternion cameraTargetRotation;

	void Start ()
	{
		cameraTargetRotation = transform.localRotation;
	}

	// Update is called once per frame
	void Update () 
	{
		if(invertVerticalAxis)
		{ flipVerticalAxis = -1.0f; }
		else
		{ flipVerticalAxis = 1.0f; }

		float vertRotation = Input.GetAxis(verticalAxis)*baseRotationSpeed*sensitivityMultiplier*flipVerticalAxis;
	
		cameraTargetRotation = ClampRotationAroundXAxis (cameraTargetRotation);

		cameraTargetRotation *= Quaternion.Euler (-vertRotation, 0f, 0f);
//		Debug.Log (cameraTargetRotation.eulerAngles.x);
//		Debug.Log (vertRotation);

		//transform.localRotation = cameraTargetRotation;
		transform.localRotation = Quaternion.Slerp(transform.localRotation, cameraTargetRotation, smoothTime * Time.deltaTime);
	}

	Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		q.x /= q.w;
		q.y /= q.w;
		q.z /= q.w;
		q.w = 1.0f;
		
		float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan (q.x);
		
		angleX = Mathf.Clamp (angleX, verticalLimitMin, verticalLimitMax);
		
		q.x = Mathf.Tan (0.5f * Mathf.Deg2Rad * angleX);
		
		return q;
	}
}
