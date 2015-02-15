using UnityEngine;
using System.Collections;

public class DestroyZombie : MonoBehaviour {
	//Found on tutorial at https://www.youtube.com/watch?v=EVlTqicntDY kinda, it was a mock of DestoryBullet, but I used it for this too.
	
	public float destoryTime = 30;
	//after 30 seconds, delete the zombie (about 4 seconds after passing bottom of the screen)
	void Update () {
		Destroy (gameObject, destoryTime);
	}
}
