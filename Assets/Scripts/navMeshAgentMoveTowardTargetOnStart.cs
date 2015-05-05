using UnityEngine;
using System.Collections;

public class navMeshAgentMoveTowardTargetOnStart : MonoBehaviour {

	public Transform target;

	public NavMeshAgent agent;
	
	void Start () {
		agent = GetComponent<NavMeshAgent>();

	}

	void FixedUpdate () {
		agent.destination = target.position; 
	}
}
