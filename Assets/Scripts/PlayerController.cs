using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private MovementController movementController;
	private MouseRaycaster raycaster;

	void Start() {
		movementController = GetComponent<MovementController>();
		raycaster = new MouseRaycaster(movementController.transform.position);
	}

	void Update() {
		if (Input.GetMouseButton(0))
			movementController.setTarget(raycaster.getHitPoint());
	}
}
