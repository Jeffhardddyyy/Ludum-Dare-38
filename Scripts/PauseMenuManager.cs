using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour {
	public GameObject PauseUI;
	public bool isPaused = false;

	public GameObject GameManager;
	public GameObject Player;
	public GameObject Enemy1;
	public GameObject Enemy2;



	private void Update()
	{
		
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}


		if(isPaused == true)
		{
			GameManager.GetComponent<GenerateEnemies>().enabled = false;
			GameManager.GetComponent<HungerManager>().enabled = false;
			Player.GetComponent<PlayerManager>().enabled = false;
			Player.GetComponent<Player_DefenseManager>().enabled = false;
			Player.GetComponent<Player_ATTACK>().enabled = false;
			Player.GetComponent<Player_Death>().enabled = false;
			Enemy1.GetComponent<Enemy1_Manager>().enabled = false;
			Enemy1.GetComponent<Enemy_PathFinding>().enabled = false;
			Enemy2.GetComponent<Enemy_PathFinding>().enabled = false;
			Enemy2.GetComponent<Enemy2_Manager>().enabled = false;

			Cursor.visible = true;
			PauseUI.SetActive(true);
		}

		if (isPaused == false)
		{
			GameManager.GetComponent<GenerateEnemies>().enabled = true;
			GameManager.GetComponent<HungerManager>().enabled = true;
			Player.GetComponent<PlayerManager>().enabled = true;
			Player.GetComponent<Player_DefenseManager>().enabled = true;
			Player.GetComponent<Player_ATTACK>().enabled = true;
			Enemy1.GetComponent<Enemy1_Manager>().enabled = true;
			Enemy1.GetComponent<Enemy_PathFinding>().enabled = true;
			Enemy2.GetComponent<Enemy_PathFinding>().enabled = true;
			Enemy2.GetComponent<Enemy2_Manager>().enabled = true;


			Cursor.visible = false;
			PauseUI.SetActive(false);
		}
	}

	public void Resume()
	{
		isPaused = false;
	}

	public void ChangeScene(string SN)
	{//STRING NAME
		SceneManager.LoadScene(SN);
	}

	public void ResetPosition()
	{
		Player.transform.position = new Vector3(20, 1, 30);
	}

}
