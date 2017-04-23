using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingApple : MonoBehaviour
{
	public PlayerManager PM;
	public HungerManager HM;
	public MoneyManager MM;

	public GameObject NotEnoughUI;

	private bool isMousedOver;


	private void OnMouseOver()
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

			GUI.Box(new Rect(Screen.width - 200, 150, 150, Screen.height), "Stats \n Name : Food \n Hunger : -1 \n Price : 10 Mun Munz \n Press Space To Buy");

		}
	}

	private void Update()
	{
		if (isMousedOver == true)
		{
			if (Input.GetKeyDown(KeyCode.Space))
				if (1 <= HM.HungerLevel)
				{
					if (10 <= MM.Balance)
					{
						HM.HungerLevel--;
						PM.Health += 5;
						MM.Balance -= 10;
						PM.SaturationXP += 0.01f;

						if (MM.Balance < 10)
						{
							StartCoroutine("NotEnough");
						}
					}
				}
		}
	}



	IEnumerator NotEnough()
	{
		yield return new WaitForSeconds(0);
		NotEnoughUI.SetActive(true);
		yield return new WaitForSeconds(3);
		NotEnoughUI.SetActive(false);
	}
}