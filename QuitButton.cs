/*
Description: This is the script to quit the game attached to a button in the pause menu.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
	public void quitButton ()
	{
		Application.Quit();
	}
	
}
