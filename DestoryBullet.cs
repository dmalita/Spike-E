using UnityEngine;
using System.Collections;

public class DestoryBullet : MonoBehaviour {
	//Found on tutorial at https://www.youtube.com/watch?v=EVlTqicntDY

	private bool isCorrect = false;
	private float savedTime;


	//When the bullet object goes offscreen, delete the bullet.
	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
	//when bullet object enters the collision space of anything with the enemy tag, delete the enemy and the bullet.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy(other.gameObject);
			Destroy(gameObject);
				}
		if (other.gameObject.tag == "Box") {
			savedTime = Time.timeScale;
			Time.timeScale = 0;
			isCorrect = true;
			OnGUI();
				}

	}
	void OnGUI(){
		Rect windowRect = new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75, 300, 250);
		if (isCorrect)
		{
			GUI.Window(0, windowRect, showGUI, "Hello");
		}
	}
	
	void showGUI(int windowID)
	{
		if (isCorrect)
		{
			string text = "Hello Traveller, I am here to help you. \n I hope you can figure this out \n ";
			// You may put a label to show a message to the player
			GUI.Label(new Rect(65, 40, 200, 100), text);
		}
		
		// You may put a button to close the pop up too
		if (GUI.Button(new Rect(50, 150, 75, 30), "OK"))
		{
			Time.timeScale = savedTime;
			isCorrect = false;
			// you may put other code to run according to your game too
		}
	}
}	
