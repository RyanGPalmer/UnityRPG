using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core {
	public class MouseRaycaster {
		private RaycastHit[] lastHits;

		public MouseRaycaster(Vector3 startPoint) {
			lastHits = new RaycastHit[] {
				new RaycastHit {
					point = startPoint
				}
			};
		}

		public RaycastHit[] getHits() {
			RaycastHit[] hits = Physics.RaycastAll(getMouseRay());
			if (hits.Length > 0)
				lastHits = hits;

			return lastHits;
		}

		private Ray getMouseRay() {
			return Camera.main.ScreenPointToRay(Input.mousePosition);
		}
	}
}