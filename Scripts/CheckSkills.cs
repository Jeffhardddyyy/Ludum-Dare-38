using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSkills : MonoBehaviour {
	private bool active = false;

	public PlayerManager PLAYERMAN;

	void Update () {
		if(Input.GetKey(KeyCode.P))
		{
			active = true; 
		}

		if(Input.GetKeyUp(KeyCode.P))
		{
			active = false;
		}
	}


	private void OnGUI()
	{
		if(active == true)
		{
		GUI.Box(new Rect(Screen.width / 2, 0, 250, Screen.height), "Skills : \n Speed :" + PLAYERMAN.MovementSpeedXP  + "\n Strength :" + PLAYERMAN.AttackDamageXP + "\n Saturation :" + PLAYERMAN.SaturationXP);
		}
	}
}
