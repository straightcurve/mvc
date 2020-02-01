#pragma strict


function OnTriggerEnter (info : Collider) {

	if (info.tag == "Player")
	{
		Application.LoadLevel (Application.loadedLevel + 1);
		Destroy(gameObject);

	}
}
function GameMeniu () {
	Application.LoadLevel("Meniu");
}
