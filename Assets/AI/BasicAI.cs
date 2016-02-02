using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour {

	public float Distance;
	public Transform Target;
    public GameObject Targette;
	public float lookAtDistance= 25.0f;
	public float chaseRange= 150.0f;
	public static float moveSpeed = 5f;

	/*
   This ai will fly and move through objects inlcuding terrain!
 */
	void  Update (){

		// Gauge the distance to the player. Line in 3d space. Draws a line from source to Target.
		Distance = Vector3.Distance(Target.position, transform.position);

		// AI begins tracking player.
		if (Distance < lookAtDistance)
		{
			lookAt();
		}

		// Attack! Chase the player until/if player leaves attack range.
		if (Distance < chaseRange){
			chase ();
		}
        if (Distance <4)
        {
            Destroy(Targette.gameObject);
            Application.LoadLevel(0);
        } 
		if (Distance > 25) {
			moveSpeed = 25f;
		}
		else {
			moveSpeed = 5f;
		}
			

	}

	// Turn to face the player.
	void  lookAt (){
		// Rotate to look at player.
		Quaternion rotation= Quaternion.LookRotation(Target.position - transform.position);

		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
		//transform.LookAt(Target); alternate way to track player replaces both lines above.
	}

	void  chase (){
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);    
	}
}