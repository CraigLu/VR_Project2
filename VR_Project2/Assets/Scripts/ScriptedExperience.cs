using UnityEngine;
using System.Collections;
using System.Runtime.Remoting.Messaging;

public class ScriptedExperience : MonoBehaviour {
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;
	public AudioSource audio5;
	public AudioSource audio6;
	public CardboardHead head;
	IEnumerator Start () {
		Quaternion rotate = new Quaternion ();
		rotate.Set (0, 0, 0, 0);
		head = GetComponent<CardboardHead> ();
		head.trackRotation = false;
		head.trackPosition = false;
		audio1.Play ();
		yield return new WaitForSeconds (audio1.clip.length);
		audio2.Play ();
		yield return new WaitForSeconds (audio2.clip.length);
		audio3.Play ();
		yield return new WaitForSeconds (3);
		head.trackRotation = true;
		head.trackPosition = true;
		yield return new WaitForSeconds (audio3.clip.length - 3);
		audio4.Play ();
		yield return new WaitForSeconds (9);
		audio4.transform.localPosition = new Vector3 (1, 0, 0);
		audio4.spatialBlend = 1f;
		audio4.panStereo = .4f;
		audio4.maxDistance = 50;
		audio4.minDistance = 3;
		yield return new WaitForSeconds (audio4.clip.length - 9);
		audio4.spatialBlend = 0;
		audio4.panStereo = 0;
		audio4.maxDistance = 500;
		audio4.minDistance = 1;
	}
}
