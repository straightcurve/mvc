#pragma strict

var efectBanut : Transform;
var valoareBanut = 1;

function OnTriggerEnter (info : Collider) {

	if (info.tag == "Player")
	{
		Destroy(gameObject);
		GameMaster.scorCurent += valoareBanut;
		Scor.scorFinal += valoareBanut;
		var efect = Instantiate(efectBanut, transform.position, transform.rotation);
		Destroy(efect.gameObject, 3);
	}
}



