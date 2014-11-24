using UnityEngine;
using System.Collections;


public class Controller : MonoBehaviour {
	public float speed = 2.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	public GameObject carebear;

	private Vector3 moveDirection = Vector3.zero;

	void Update() {
		moveDirection = Vector3.zero;
		if (Input.GetKey("left")) {
			moveDirection += new Vector3(-1, 0, 0);
		}

		if (Input.GetKey("right")) {
			moveDirection += new Vector3(1, 0, 0);
		}

		if (Input.GetKey("down")) {
			moveDirection += new Vector3(0, 0, -1);
		}

		if (Input.GetKey("up")) {
			moveDirection += new Vector3(0, 0, 1);
		}

		moveDirection *= speed;


		if (Input.GetKey ("r")) {
			transform.position = new Vector3(0, 0, 1);
				}

		carebear.transform.LookAt (transform.position);
		moveDirection = carebear.transform.TransformDirection(moveDirection); 

		if (Input.GetKeyDown("x")) {
			moveDirection += new Vector3(0, jumpSpeed, 0);
		}

		moveDirection += new Vector3 (0, -gravity, 0);


		rigidbody.AddForce (moveDirection);
		//rigidbody.MovePosition (moveDirection);
	}
}