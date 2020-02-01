#pragma strict

function OnTriggerEnter (info : Collider) {

	if (info.tag == "Player")
	{
		Application.LoadLevel("Meniu");
		Destroy(gameObject);

	}
}