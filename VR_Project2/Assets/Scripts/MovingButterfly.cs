using UnityEngine;
using System.Collections;

public class MovingButterfly : MonoBehaviour 
{

	public float horizontalspeed;
	public float verticalspeed;
	public float aplitude;

	private Vector3 tempPosition;

	void Start () 
	{
		tempPosition = transform.position;
	}

	void FixedUpdate () 
	{
		tempPosition.x += horizontalspeed;
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalspeed) * aplitude;
		transform.position = tempPosition;
	}
}