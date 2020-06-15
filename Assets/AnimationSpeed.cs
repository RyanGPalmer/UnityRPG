using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationSpeed : MonoBehaviour {
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private NavMeshAgent navMeshAgent;

	[SerializeField]
	private string speedVariableName;

	void Update() {
		animator.SetFloat(speedVariableName, navMeshAgent.velocity.magnitude);
	}
}
