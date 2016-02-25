using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath ("Fish2"), "time", 150));
	}
}
