using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Use this for initialization
	void FixedUpdate () {
		float speed = Random.Range(0.5f, 1.2f);
		Vector3 position = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
		// transform.position += position * speed;
		rb.AddForce(position * speed, ForceMode.Impulse);
	}
}
