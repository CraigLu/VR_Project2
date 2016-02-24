using UnityEngine;
using System.Collections;

public class ScriptedExperience2 : MonoBehaviour {

	private AudioSource audio1;
	private AudioSource audio2;
	public GameObject dragon;
	public GameObject fire;
	private SphereCollider trigger;
	private Autowalk walk;


	void Start(){
		audio1 = GameObject.FindGameObjectWithTag ("ScriptedFire").GetComponent<AudioSource>();
		audio2 = GameObject.FindGameObjectWithTag ("ScriptedScare").GetComponent<AudioSource>();
		walk = GameObject.FindGameObjectWithTag ("Character").GetComponent<Autowalk>();
		trigger = GameObject.FindGameObjectWithTag ("Campfire").GetComponent<SphereCollider>();
		fire.SetActive (false);
		dragon.SetActive (false);
		trigger.isTrigger = true;
	}

	IEnumerator OnTriggerEnter(){
		walk.isWalking = false;
		walk.walkWhenTriggered = false;
		walk.Normal.Stop ();
		audio1.Play ();
		yield return new WaitForSeconds (audio1.clip.length);
		audio2.Play ();
		yield return new WaitForSeconds (4);
		dragon.SetActive (true);
		fire.SetActive (true);
		yield return new WaitForSeconds (4);
		fire.SetActive (false);
		yield return new WaitForSeconds (1);
		dragon.SetActive (false);
		walk.walkWhenTriggered = true;
		trigger.radius = 1;
		trigger.isTrigger = false;
	}
}
