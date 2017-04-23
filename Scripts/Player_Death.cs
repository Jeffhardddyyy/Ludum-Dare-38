using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Death : MonoBehaviour
{
	public GameObject GameManager;
	public GameObject Player;

	public GameObject Enemy1;
	public GameObject Enemy2;

	public bool isDead;


	public GameObject DeathUI;

	private void Update()
	{
	
		if(isDead == true)
		{
			DeathFunction();
		}

	}



	public void DeathFunction()
	{
		DeathUI.SetActive(true);
		GameManager.GetComponent<GenerateEnemies>().enabled = false;
		Player.GetComponent<PlayerManager>().enabled = false;
		Player.GetComponent<Player_DefenseManager>().enabled = false;
		Player.GetComponent<Player_ATTACK>().enabled = false;
		Player.GetComponent<Player_Death>().enabled = false;
		Enemy1.GetComponent<Enemy1_Manager>().enabled = false;
		Enemy1.GetComponent<Enemy_PathFinding>().enabled = false;
		Enemy2.GetComponent<Enemy_PathFinding>().enabled = false;
		Enemy2.GetComponent<Enemy2_Manager>().enabled = false;


	}
}