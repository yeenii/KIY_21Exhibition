using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform[] views;
	public float transitionSpeed;

	public void changeView(int index)
	{
		//Lerp position
		Vector3 new_position = views[index].transform.position;

		Vector3 currentAngle = views[index].transform.eulerAngles;

		transform.position = new_position;
		transform.eulerAngles = currentAngle;

	}

	// Use this for initialization
	void Start()
	{
		changeView(0);
	}

}
