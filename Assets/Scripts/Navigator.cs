using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour {
	private NavMeshAgent navMeshAgent;
	private Vector3 target;

	void Start() {
		navMeshAgent = GetComponent<NavMeshAgent>();
		target = gameObject.transform.position; // Target self on start
	}

	void Update() {
		if (Input.GetMouseButton(0)) {
			target = getMouseHitPoint();
			navMeshAgent.SetDestination(target);
		}
	}

	private Vector3 getMouseHitPoint() {
		RaycastHit hit;
		if (Physics.Raycast(getMouseRay(), out hit))
			return hit.point;

		return target; // No hit, just return existing target
	}

	private Ray getMouseRay() {
		return Camera.main.ScreenPointToRay(Input.mousePosition);
	}
}
