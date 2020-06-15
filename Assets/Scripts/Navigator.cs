using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour {
	private Vector3 target;
	private NavMeshAgent navMeshAgent = null;

	void Start() {
		target = gameObject.transform.position; // Target self on start
	}

	void Update() {
		if (Input.GetMouseButton(0))
			updateTarget();

		getNavMeshAgent().SetDestination(target);
	}

	private void updateTarget() {
		target = getMouseHitPoint();
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

	private NavMeshAgent getNavMeshAgent() {
		if (navMeshAgent == null)
			navMeshAgent = GetComponent<NavMeshAgent>();

		return navMeshAgent;
	}
}
