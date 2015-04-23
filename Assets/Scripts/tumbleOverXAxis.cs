using UnityEngine;
using System.Collections;

public class tumbleOverXAxis : MonoBehaviour {

	public float rotationRate = 360.0f;
	public float xAngle = 0.0f;
	public float yAngle = 0.0f;
	public float zAngle = 0.0f;

	void Update () 
	{
		xAngle = (rotationRate*Time.deltaTime);
		/*if(xAngle>=360.0f)
		{
			xAngle = 0.0f;
		}*/
		transform.Rotate (xAngle,yAngle,zAngle);
	}
}
