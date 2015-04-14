using UnityEngine;
using System.Collections;

public class moveOnAxisInput : MonoBehaviour 
{
	public string horizontalMoveAxis = "HorizontalMove";
	public string verticalMoveAxis = "VerticalMove";

	public string horizontalLookAxis = "HorizontalLook";
	public float baseRotationSpeed = 3.0f;
	public float sensitivityMultiplier = 1.0f;
	public bool invertHorizontalAxis = false;
	public float flipHorizontalAxis = -1.0f;
	public bool smoothHorizontalRotation = true;
	public float smoothTime = 8.0f;

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	private Quaternion playerTargetRotation = Quaternion.identity;
	private Vector3 moveDirection = Vector3.zero;

	void Update() 
	{
		CharacterController controller = GetComponent<CharacterController>();

		if (controller.isGrounded) 
		{

			moveDirection = new Vector3(Input.GetAxis(horizontalMoveAxis), 0, Input.GetAxis(verticalMoveAxis));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
			
		}

		if(invertHorizontalAxis) 
		{ flipHorizontalAxis = -1.0f; }
		else 
		{ flipHorizontalAxis = 1.0f; }

		float horizontalRotation = Input.GetAxis(horizontalLookAxis)*baseRotationSpeed*sensitivityMultiplier*flipHorizontalAxis;
		playerTargetRotation *= Quaternion.Euler (0f, horizontalRotation, 0f);

		if(smoothHorizontalRotation)
		{
			transform.localRotation = Quaternion.Slerp(transform.localRotation, playerTargetRotation, smoothTime * Time.deltaTime);
		}
		else
		{
			transform.localRotation = playerTargetRotation;		
		}

		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move(moveDirection * Time.deltaTime);
	}
}
