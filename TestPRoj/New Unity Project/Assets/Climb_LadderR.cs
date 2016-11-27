using UnityEngine;
using System.Collections;

public class Climb_LadderR: MonoBehaviour

{
	//StartTime finds the time that the collision begins
	float startTime;
	//Player is the player's location in 3D space
	Vector3 player;
	//Target is the updating location of the area we wish our player to go to
	Vector3 target;
	//The speed at which the player gets to the location
	float speed = 1.0F;
	//distance between the player and target
	float journeyLength;
	//detects a collision
	public bool collide = false;
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "LadderR")
		{
			collide = true;
			//sets player vector to player's current position
			player = transform.position;
		//	finds collision target position
			target = col.gameObject.transform.position;
			//this below is to make the player look like they're climbing up and not sideways
			target.y = target.y + 2f;
			target.x = target.x - 1.5f;
			//detects time of collision

			startTime = Time.time;
			//calculates distance
			journeyLength = Vector3.Distance(player, target);
		}

	}
		
	void Update(){
		if (collide == true) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			//moves player every frame toward target
			transform.position = Vector3.Lerp (player, target, fracJourney);
		}
		if ((Time.time - startTime) > 3.0f) {
			//once the player hits the location, to move them off the collision, we push them forward
			//this number updates every frame so keep it low
			target.x = target.x + 0.05f;
		}

		if ((Time.time - startTime) > 4.0f) {
			collide = false;
		}
	}


}