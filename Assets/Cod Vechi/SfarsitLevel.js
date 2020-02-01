#pragma strict

var gameMaster : GameMaster;

function LaAtingere (colInfo : Collider) {
	if (colInfo.tag == "Player"){
	Application.LoadLevel (Application.loadedLevel + 1);
	}
}

