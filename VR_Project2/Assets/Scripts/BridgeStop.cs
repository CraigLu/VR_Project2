using UnityEngine;
using System.Collections;
using UnityStandardAssets.Water;

public class BridgeStop : MonoBehaviour {
	public AudioSource audio1;
	public AudioSource audio2;
	private Water river;
	public GameObject waterfall;
	private Autowalk walk;
	public GameObject box;
	void Start () {
		walk = GameObject.FindGameObjectWithTag ("Character").GetComponent<Autowalk>();
		river = GameObject.FindGameObjectWithTag ("Water").GetComponent<Water>();
		river.waterMode = Water.WaterMode.Simple;
		waterfall.SetActive (false);
	}

	IEnumerator OnTriggerEnter(){
		walk.isWalking = false;
		walk.walkWhenTriggered = false;
		walk.Wood.Stop ();
		audio1.Play ();
		yield return new WaitForSeconds (audio1.clip.length);
		waterfall.SetActive (true);
		river.waterMode = Water.WaterMode.Refractive;
		audio2.Play ();
		yield return new WaitForSeconds (audio2.clip.length);
		river.waterMode = Water.WaterMode.Simple;
		walk.walkWhenTriggered = true;
		box.SetActive (false);

	}
}
