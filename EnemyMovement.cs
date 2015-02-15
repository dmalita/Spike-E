using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	//Tutorial Found at: https://www.youtube.com/watch?v=K8ENpEvDUtM

	//Start and End Positions
	float startingPos;
	float endPos;
	//Units enemy moving to the right
	public float unitsToMove = 6;
	//Speed of enemy
	public int moveSpeed = 5;
	//Enemy Trigger
	bool moveRight = true;
	bool moveDown = true;
	//Choosing down or right to move in the interface
	public bool goRight = true;
	public bool goDown = false;

	//Only the code involved inside the goRight function was in the tutorial, I modified it for my uses.
	void Awake()
	{
		if (goRight) {
						//On load gets our enemies starting x
						startingPos = transform.position.x;
						//on load gets our enemies starting end pos by adding the units to the starting pos.
						endPos = startingPos + unitsToMove;
				}
		if (goDown) {
						//On load gets our enemies starting y
						startingPos = transform.position.y;
						//on load gets our enemies starting end pos by adding the units to the starting pos.
						endPos = startingPos + unitsToMove;
				}
	}
	// Only "MoveRight" code was in the tutorial, I added the boolean value and the entire goDown part of this code
	void Update () {
			//For when the enemy goes right then left
				if (goRight) 
				{
					if (moveRight) 
					{
						rigidbody.position += Vector3.right * moveSpeed * Time.deltaTime;
					} 
					else 
					{
						rigidbody.position += Vector3.left * moveSpeed * Time.deltaTime;
					}
					if (rigidbody.position.x >= endPos) 
					{
						moveRight = false;
					}
					if (rigidbody.position.x <= startingPos - endPos) 
					{
						moveRight = true;
					}
				}
		//For When the Enemy will go down then up
			    if (goDown) 
				{
					if (moveDown) 
					{
						rigidbody.position += Vector3.down * moveSpeed * Time.deltaTime;
					} 
					else 
					{
						rigidbody.position += Vector3.up * moveSpeed * Time.deltaTime;
					}
					if (rigidbody.position.y >= endPos) 
					{
						moveDown = false;
					}
					if (rigidbody.position.y <= startingPos - endPos) 
					{
						moveDown = true;
					}
				}
		}
}
