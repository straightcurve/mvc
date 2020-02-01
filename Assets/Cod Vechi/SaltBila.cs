using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltBila : MonoBehaviour {

	private bool jumped;
	private float originalY;
	public float jumpSpeed;
	private int count;

	// Use this for initialization
	void Start () {

		jumpSpeed = 0.1f;
		originalY = this.transform.position.y;
	}

	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 || Input.GetMouseButtonDown (0))
		{
			jumped = true;
		}
		if (jumped) {

			jumpNow ();
		}


	}

	void jumpNow()
	{
		if (count < 30) {

			Vector3 position = this.transform.position;
			position.y += jumpSpeed;
			count++;
			this.transform.position = position;
		} else {

			if (transform.position.y > originalY) {

				Vector3 position = this.transform.position;
				position.y -= jumpSpeed;
				this.transform.position = position;
			} else {

				count = 0;
				jumped = false;
			}
		}
	}
}