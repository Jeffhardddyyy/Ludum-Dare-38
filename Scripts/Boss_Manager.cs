using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Manager : MonoBehaviour
{


	private bool isMousedOver;

	[Header("Stats")]
	public float Health;



	[Header("Stuff")]
	public MoneyManager Balance;
	public PlayerManager PlayerMan;
	
	[Header("UI")]
	public GameObject Boss_Summoned;

	private void Start()
	{
		if(gameObject.name.Contains("Clone"))
		{
			StartCoroutine("DESPAWN");
			StartCoroutine("Alert");
		}

		Health = Random.Range(100, 200);
		Health = Mathf.Round(Health);
	}

	IEnumerator DESPAWN()
	{
		yield return new WaitForSeconds(Random.Range(60, 120));
		Destroy(gameObject, 0);
	}

	IEnumerator Alert()
	{
		yield return new WaitForSeconds(0);
		Boss_Summoned.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		Boss_Summoned.SetActive(false);
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Stick")
		{
			if (PlayerMan.AttackDamageXP <= 0.5f)
			{
				PlayerMan.AttackDamageXP = PlayerMan.AttackDamageXP + 0.002f;
			}



			Health = Health - 1 + PlayerMan.AttackDamage;
			Health = Mathf.Round(Health);
		}

		else if (other.tag == "Spear")
		{
			if (PlayerMan.AttackDamageXP <= 0.5f)
			{
				PlayerMan.AttackDamageXP = PlayerMan.AttackDamageXP + 0.002f;
			}


			Health = Health - 3 + PlayerMan.AttackDamage;
			Health = Mathf.Round(Health);

		}

		else if (other.tag == "Axe")
		{
			if (PlayerMan.AttackDamageXP <= 0.5f)
			{
				PlayerMan.AttackDamageXP = PlayerMan.AttackDamageXP + 0.002f;
			}


			Health = Health - 5 + PlayerMan.AttackDamage;
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


		Balance.Balance = Balance.Balance + Random.Range(100, 110);
	}
}