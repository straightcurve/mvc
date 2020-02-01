#pragma strict

static var scorFinal : int = 0;

var pozitieY : float = 30;
var marimeY : float = 45;
var marimeX : float = 500;

var font: Font;
var fontSize : int = 32;

function OnGUI () {
	GUI.Box (new Rect (Screen.width/2-500/2, pozitieY, marimeX, marimeY), "Felicitari ai strans  " + scorFinal + "  monede "); 
	GUI.skin.label.font = GUI.skin.button.font = GUI.skin.box.font = font;
	GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
}
