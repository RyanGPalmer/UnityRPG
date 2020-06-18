using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycaster {
	private Vector3 lastHitPoint;

	public MouseRaycaster(Vector3 startPoint) {
		lastHitPoint = startPoint;
	}

	public Vector3 getHitPoint() {
		RaycastHit hit;
		if (Physics.Raycast(getMouseRay(), out hit))
			lastHitPoint = hit.point;

		return lastHitPoint;
	}

	private Ray getMouseRay() {
		return Camera.main.ScreenPointToRay(Input.mousePosition);
	}
}
