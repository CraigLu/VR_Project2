using UnityEngine;
using System.Collections;

public class ScriptedExperience2 : MonoBehaviour {

	private AudioSource audio1;
	private AudioSource audio2;

	void Start(){
		audio1 = GameObject.FindGameObjectWithTag ("ScriptedFire").GetComponent<AudioSource>();
		audio2 = GameObject.FindGameObjectWithTag ("ScriptedScare").GetComponent<AudioSource>();
	}

	IEnumerator OnTriggerEnter(){
		audio1.Play ();
		yield return new WaitForSeconds (audio1.clip.length);
		audio2.Play ();
		yield return new WaitForSeconds (audio2.clip.length);
	}
}
