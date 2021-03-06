﻿#pragma strict

var fire : GameObject;
var spark : GameObject;
public var myLight : Light;
public var AudioFile : AudioSource;
function Start () {

	fire.SetActive(false);
	spark.SetActive(false);
	myLight.intensity = 0;
	AudioFile.Stop();
}

function OnTriggerEnter () {
	fire.SetActive(true);
	spark.SetActive(true);
	myLight.intensity = 4;
	AudioFile.Play();
}