using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class SwitchCamera : MonoBehaviour {
	private StereoController stereo;
	void Start () {
		stereo = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<StereoController>();
		stereo.stereoMultiplier = 0.0f;
	}
	void OnTriggerEnter(){
		stereo.stereoMultiplier = 1.0f;
	}
}
