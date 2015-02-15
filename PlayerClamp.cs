using UnityEngine;
using System.Collections;

public class PlayerClamp : MonoBehaviour {

	//Tutorial Found at: https://www.youtube.com/watch?v=7PczMVUDsEY

	public float leftClamp = -7.5f;
	public float rightClamp = 7.5f;
	public float topClamp = 4.4f;
	public float bottomClamp = -4.4f;
	//Only x value clamp was in the tutorial, I modified to allow for the y value
	void Update () 
	{
		if (rigidbody.position.x <= leftClamp || rigidbody.position.x >= rightClamp) 
		{
			Vector3 pos = rigidbody.position;

			pos.x = Mathf.Clamp(pos.x,leftClamp,rightClamp);

			rigidbody.position = pos;
		}
		if (rigidbody.position.y <= bottomClamp || rigidbody.position.y >= topClamp) 
		{
			Vector3 pos = rigidbody.position;
			
			pos.y = Mathf.Clamp(pos.y,bottomClamp,topClamp);
			
			rigidbody.position = pos;
		}

	}
}
