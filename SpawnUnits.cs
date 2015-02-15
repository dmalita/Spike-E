using UnityEngine;
using System.Collections;

public class SpawnUnits : MonoBehaviour {
	//This is my own script and I'm pretty freakin' proud I did this without a tutorial
	public GameObject Enemy_Down;
	int timer = -300;
	int spawnTime;
	int harderOverTime = 0;
	int startingSpawnTimer;
	public int SpawnGap_START_point = 400;
	public int SpawnGap_CHANGE_point = 25;
	/*
	 * Creates the spawnTime and startingSpawnTimer.
	 * Really the startingSpawnTimer just makes it so the start point isn't perfect, each game will be different
	 */
	void Start()
	{
		spawnTime = SpawnGap_START_point;
		startingSpawnTimer = Random.Range (160,200);
	}
	/*
	 * Timer increase per update
	 * if the timer hits the spawn time
	 * run spawn method
	*/
	void Update () 
	{
		timer++;
		if(timer == spawnTime)
		SpawnZombie();

		//My Own attempt to get when the zombies get to the point of the game I would want to trigger the end.  This never worked.
		if (Enemy_Down.gameObject.transform.position.y <= -4f) {
			Debug.Log("Enemy Passed Computers");
				}
	}
	/*
	 * Creates a new Zombie
	 * resets the timer
	 * creates a new random spawn timer, the gap of the randomization will close as the game progresses
	 * once there is no more randomization it will set the value to be +1 of the startvalue (never ending spawn)
	 * */
	void SpawnZombie()
	{
		//This is the only line of code I had to look up
		Instantiate (Enemy_Down, transform.position, transform.rotation);
		//Me again
		timer = -300;
		spawnTime = Random.Range(startingSpawnTimer,startingSpawnTimer+SpawnGap_START_point - harderOverTime);
		if (harderOverTime < SpawnGap_START_point-1) {
			harderOverTime += SpawnGap_CHANGE_point;
				} else
					harderOverTime = SpawnGap_START_point-1;

	}
}
