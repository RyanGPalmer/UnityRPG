using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
	[SerializeField]
	private Transform target;

	void Update() {
		transform.position = target.position;
	}
}
