using UnityEngine;
using System.Collections;

public class Movement1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath ("Fish1"), "time", 300));
	}
}
