using UnityEngine;
using System.Collections;

public class Movement1 : MonoBehaviour {
	public iTween tween;
	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath ("Fish1"), "time", 300));
		tween.loopType = iTween.LoopType.pingPong;
	}
}
