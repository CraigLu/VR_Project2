using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo (gameObject, iTween.Hash("path", iTweenPath.GetPath ("Horse"), "Time", 100));
	}
}
