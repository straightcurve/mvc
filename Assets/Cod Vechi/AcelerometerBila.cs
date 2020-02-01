using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerometerBila : MonoBehaviour {


	public bool isTrue = true;
	//public float speed = 3.0f;
	private Rigidbody rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 miscare = Input.acceleration;

		if (isTrue)
			miscare = Quaternion.Euler (90, 0, 0) * miscare;

		rigid.AddForce (miscare);
		Debug.DrawRay (transform.position + Vector3.up, miscare, Color.red);
	}
}
