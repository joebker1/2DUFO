/*
Description: This spins the coins to make them enticing to the player.
*/

using UnityEngine;
using System.Collections;


public class Rotater : MonoBehaviour
{
	
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
    }
    

    
}
