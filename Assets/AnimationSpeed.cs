using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationSpeed : MonoBehaviour {
	[SerializeField]
	private string speedVariableName;

	private Animator animator;
	private NavMeshAgent navMeshAgent;

	private void Start() {
		animator = GetComponent<Animator>();
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	void Update() {
		animator.SetFloat(speedVariableName, navMeshAgent.velocity.magnitude);
	}
}
