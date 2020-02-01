#pragma strict

static var scorCurent : int = 0;
static var viataCurenta : int = 3;

var pozitieY : float = 8;
var marimeY : float = 45;
var marimeX : float = 180;
var pozitieY2 : float = 8;
var marimeY2 : float = 45;
var marimeX2 : float = 120;

var font: Font;
var fontSize : int = 32;

function OnGUI () {
	GUI.Box (new Rect (Screen.width/2-180/2, pozitieY, marimeX, marimeY), "Monede " + scorCurent);
	GUI.Box (new Rect (Screen.width/120, pozitieY2, marimeX2, marimeY2), "Vieti " + viataCurenta);   
	GUI.skin.label.font = GUI.skin.button.font = GUI.skin.box.font = font;
	GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
}


function StagiuUrmator ()
{
	Application.LoadLevel (Application.loadedLevel + 1);
}

