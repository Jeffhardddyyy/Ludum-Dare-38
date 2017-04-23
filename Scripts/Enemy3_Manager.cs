using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3_Manager : MonoBehaviour
{


	private bool isMousedOver;

	[Header("Stats")]
	public float Health;



	[Header("Stuff")]
	public MoneyManager Balance;
	public PlayerManager PlayerManager;


	private void Start()
	{
		Health = Random.Range(20, 50);
		Health = Mathf.Round(Health);
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Stick")
		{
			if (PlayerManager.AttackDamageXP <= 0.5f)
			{
				PlayerManager.AttackDamageXP = PlayerManager.AttackDamageXP + 0.0001f;
			}

			Health = Health - 1 + PlayerManager.AttackDamageXP;
			Health = Mathf.Round(Health);

		}

		else if (other.tag == "Spear")
		{
			if (PlayerManager.AttackDamageXP <= 0.5f)
			{
				PlayerManager.AttackDamageXP = PlayerManager.AttackDamageXP + 0.0001f;
			}


			Health = Health - 3 + PlayerManager.AttackDamageXP;
			Health = Mathf.Round(Health);

		}

		else if (other.tag == "Axe")
		{
			if (PlayerManager.AttackDamageXP <= 0.5f)
			{
				PlayerManager.AttackDamageXP = PlayerManager.AttackDamageXP + 0.0001f;
			}


			Health = Health - 5 + PlayerManager.AttackDamageXP;
			Health = Mathf.Round(Health);

		}

		if (Health <= 0)
		{
			EnemyDie();
		}
	}

	private void OnMouseEnter()
	{
		isMousedOver = true;
	}

	private void OnMouseExit()
	{
		isMousedOver = false;
	}


	private void OnGUI()
	{
		if (isMousedOver == true)
		{
			GUI.Box(new Rect(Screen.width / 2, 0, Screen.width / 3, Screen.height / 3), " Enemy Health :" + Health);
		}
	}



	public void EnemyDie()
	{
		//death particle?
		Destroy(gameObject, 0);


		Balance.Balance = Balance.Balance + Random.Range(3, 5);
	}
}