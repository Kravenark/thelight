using UnityEngine;
using System.Collections;

public class Camera_Follow : MonoBehaviour {
	
	public Transform ball;
	Camera myCamera;
	// Use this for initialization

	void Start () {
		myCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame

	void Update () {
		if (ball) {
			transform.position = Vector3.Lerp (transform.position, ball.position, 0.05f) + new Vector3 (0, 0, -0.35f);
		}
	}
}
