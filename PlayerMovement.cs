using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//Tutorial Found At: https://www.youtube.com/watch?v=lLamomxbCQY

	public int playerSpeed = 5;
	// Update is called once per frame



	void Update () {
		if (Input.GetKey (KeyCode.A))
			rigidbody.position += Vector3.left * playerSpeed * Time.deltaTime;
		if (Input.GetKey (KeyCode.D))
			rigidbody.position += Vector3.right * playerSpeed * Time.deltaTime;
		if (Input.GetKey (KeyCode.W))
			rigidbody.position += Vector3.up * playerSpeed * Time.deltaTime;
		if (Input.GetKey (KeyCode.S))
			rigidbody.position += Vector3.down * playerSpeed * Time.deltaTime;



	}
}
