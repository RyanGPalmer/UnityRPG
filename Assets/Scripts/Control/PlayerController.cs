using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;
using RPG.Core;
using RPG.Combat;

namespace RPG.Control {
	public class PlayerController : MonoBehaviour {
		private Mover mover;
		private Fighter fighter;
		private MouseRaycaster raycaster;

		void Start() {
			mover = GetComponent<Mover>();
			fighter = GetComponent<Fighter>();
			raycaster = new MouseRaycaster(mover.transform.position);
		}

		void Update() {
			RaycastHit[] hits = raycaster.getHits();

			if (Input.GetMouseButtonDown(0))
				handleCombat(hits);

			if (Input.GetMouseButton(0))
				handleMovement(hits);
		}

		private void handleCombat(RaycastHit[] hits) {
			CombatTarget combatTarget;
			if (getFirstCombatTarget(hits, out combatTarget))
				fighter.setTarget(combatTarget);
		}

		private bool getFirstCombatTarget(RaycastHit[] hits, out CombatTarget combatTarget) {
			foreach (RaycastHit hit in hits) {
				CombatTarget target;
				if (hit.transform.TryGetComponent(out target)) {
					combatTarget = target;
					return true;
				}
			}

			combatTarget = null;
			return false;
		}

		private void handleMovement(RaycastHit[] hits) {
			mover.setTarget(hits[0].point);
		}
	}
}