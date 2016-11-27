using UnityEngine;
using System.Collections;

public class Camera_Follow : MonoBehaviour {

    // Use this for initialization
    public Transform target;
    Camera myCamera;
	void Start () {
	myCamera = GetComponent <Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (target) {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.2f) + new Vector3 (0,0,-1);
        }

	}
}
