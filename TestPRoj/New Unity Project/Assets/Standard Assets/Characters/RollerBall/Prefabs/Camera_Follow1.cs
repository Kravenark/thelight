using UnityEngine;
using System.Collections;

public class Camera_Follow1 : MonoBehaviour {

    // Use this for initialization
    public Transform target1;
    Camera myCamera1;
	void Start () {
	myCamera1 = GetComponent <Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (target1) {
            transform.position = Vector3.Lerp(transform.position, target1.position, 0.2f) + new Vector3 (0,0,0);
        }

	}
}
