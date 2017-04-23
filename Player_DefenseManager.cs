using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_DefenseManager : MonoBehaviour {

	[Header("Player Stuff")]
	public PlayerManager PlayerMan;
	

	[Header("Defense Stuff")]
	public Text HealthNumber;           //the health number
	


	//privates
	private float Health;

	private void Update()
	{
		Health = PlayerMan.Health;      //setting the health to the PlayerManager Health
		HealthNumber.text = " " + Health;		//setting the health number text to the Health
	}

	private void OnCollisionEnter(Collision collision)
	{//OnCollisionEnter
		if(collision.collider.tag == "Enemy")
		{//if the tag is "Enemy"
			BeenAttacked();		//call the function "BeenAttacked"
		}
	}


	public void BeenAttacked()
	{//if the player is attacked
		PlayerMan.Health--;		//deduct the health by 1 (Health = Health - 1)
	}
}
