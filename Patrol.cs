/*
Description: This script is attached to an object, the Alien Slime, so that it could roam the level.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	public float speed;
	private float waitTime;
	public float startWaitTime;
	
	public Transform[] moveSpots;
	private int randomSpot;
	
	void Start()
	{
		waitTime = startWaitTime;
		randomSpot = Random.Range(0, moveSpots.Length);
	}
	
	void Update()
	{
		transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
		
		if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
		{
			if (waitTime <= 0)
			{
				randomSpot = Random.Range(0, moveSpots.Length);
				waitTime = startWaitTime;
			}
			
			else {
				waitTime -= Time.deltaTime;
			}
			
		}
		
	}
	
	
}	
