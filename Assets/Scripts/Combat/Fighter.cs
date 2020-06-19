using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat {
	public class Fighter : MonoBehaviour {
		private CombatTarget currentTarget;

		public void setTarget(CombatTarget target) {
			Debug.Log("I'm coming to get you...");
		}
	}
}