#pragma strict

var cadereBila = -5;
var viata = 1;

function Update () {
	if (transform.position.y <= cadereBila){
		Application.LoadLevel (Application.loadedLevel);
		GameMaster.viataCurenta -= viata;
		if (GameMaster.viataCurenta == 0){
			Application.LoadLevel("Meniu");
			GameMaster.viataCurenta = 3;
			GameMaster.scorCurent = 0;
			Scor.scorFinal = 0;
		}
	}
}

