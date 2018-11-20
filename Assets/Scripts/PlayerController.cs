using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	int health = 100;
	Rigidbody rb;
	public Image healthBar;
	public Text healthText;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update() {
	}

	// Update is called once per frame
	void FixedUpdate () {
		float speed = 10.0f;
        float movementH = Input.GetAxis("Horizontal") * speed;
        float movementV = Input.GetAxis("Vertical") * speed;
        float movementJ = 0;
        Vector3 movement = new Vector3(movementH, movementJ, movementV);
        rb.AddForce(movement);
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Enemy") && health > 0) {
			health -= 10;
			healthBar.fillAmount = health / 100f;

			// int tileDimension = 36;
            // Rect rect = healthBar.rectTransform.rect;
            // healthBar.rectTransform.sizeDelta = new Vector2(rect.width - tileDimension, rect.height);

			healthText.text = health.ToString() + '%';

			// Debug.Log(health);
			// Debug.Log(healthBar.fillAmount);
		}
	}
}
