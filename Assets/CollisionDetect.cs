using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {
	bool keyTaken = false;
	bool isDead = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (isDead);
		if (isDead == true) {
			Debug.Log ("TEST!!!");
			transform.Translate (Vector3.up * 10.0f * Time.deltaTime);
			Application.Quit();
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Test")
		{
			Destroy(col.gameObject);
			keyTaken = true;
		}
		if(col.gameObject.tag == "TestA")
		{
			Destroy(col.gameObject);
			isDead = true;
		}
		if(col.gameObject.name == "Test2")
		{
			if (keyTaken == true) {
			Destroy(col.gameObject);
					}
				
		
	}
}
}