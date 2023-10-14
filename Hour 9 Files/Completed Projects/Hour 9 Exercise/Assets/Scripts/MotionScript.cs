using UnityEngine;

public class MotionScript : MonoBehaviour
{
	void Update ()
	{
		//Multiplying by Time.deltaTime is a good practice as it makes the object move at 
		//the same rate regardless of how fast your computer it. This will make the object move
		//one unit per second.
		float xMovement = Input.GetAxis ("Horizontal") * Time.deltaTime;
		float yMovement = Input.GetAxis ("Vertical") * Time.deltaTime;

		transform.Translate (xMovement, yMovement , 0);
	}
}
