using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] private Rigidbody2D rb;

	void Update() {
		if (Input.GetButtonDown("Start")) {
			rb.bodyType = RigidbodyType2D.Dynamic;
		}
	}
}
