﻿using UnityEngine;
using System.Collections;

public class AudioTriggerTest : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying) {
			CardboardHead head = GetComponent<CardboardHead> ();
			head.trackRotation = false;
		}
	}
}
