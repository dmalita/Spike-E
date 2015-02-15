using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	//Script found at https://www.youtube.com/watch?v=13ttYskKCqc
	//I also editted it to allow for multiple directions for the bullet to travel
		
		public Rigidbody bulletPrefab;
		public float attackSpeed = .5f;
		public float bulletSpeed = 500;
		float cooldown;	
	public float YVar = .5f;
		
		//If the player hits one of the arrow keys, calls the fire function related to that direction
		//My code
		void Update () 
		{
			if(Time.time >= cooldown)
			{
			if(Input.GetKey(KeyCode.UpArrow))
				Fire(1);
			else if(Input.GetKey(KeyCode.DownArrow))
				Fire(2);
			else if(Input.GetKey(KeyCode.LeftArrow))
				Fire(3);
			else if(Input.GetKey(KeyCode.RightArrow))
				Fire(4);
			}
		}
		//Depending on direction code, sends the bullet out of the player in that direction.  Only UP was in the tutorial, editted it to allow for more.
		void Fire(int direction)
		{
		Rigidbody bPreFab = Instantiate (bulletPrefab, new Vector3(transform.position.x,transform.position.y + YVar,transform.position.z), Quaternion.identity) as Rigidbody;
			if (direction == 1)
						bPreFab.rigidbody.AddForce (Vector3.up * bulletSpeed);
				else if (direction == 2)
						bPreFab.rigidbody.AddForce (Vector3.down * bulletSpeed);
				else if (direction == 3)
						bPreFab.rigidbody.AddForce (Vector3.left * bulletSpeed);
				else if (direction == 4)
						bPreFab.rigidbody.AddForce (Vector3.right * bulletSpeed);
		
		cooldown = Time.time + attackSpeed;
		}
	}
	
