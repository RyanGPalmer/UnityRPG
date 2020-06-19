using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core {
	public class Follower : MonoBehaviour {
		[SerializeField]
		private Transform target;

		void LateUpdate() {
			transform.position = target.position;
		}
	}
}
