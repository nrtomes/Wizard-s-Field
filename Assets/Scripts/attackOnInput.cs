using UnityEngine;
using System.Collections;

public class attackOnInput : MonoBehaviour 
{
	public string attackPrimary = "Fire1";
	public bool isAttacking = false;

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
}
