using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
	public iTween tween;
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath ("Fish2"), "time", 150));
		tween.loopType = iTween.LoopType.pingPong;
	}
}
