using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingStick : MonoBehaviour {
	private bool isMousedOver;
	public MoneyManager MoneyMan;

	[Header("Extras")]
	public GameObject Stick;
	public GameObject Spear;
	public GameObject Axe;

	[Space]
	public GameObject NotEnoughUI;
	public GameObject AlreadyEquippedUI;


	private void OnMouseOver()
	{
		isMousedOver = true;
	}


	private void OnMouseExit()
	{
		isMousedOver = false;
	}

	private void Update()
	{
		if (isMousedOver == true)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				if (5 <= MoneyMan.Balance)
				{
				if(Stick.activeInHierarchy == false)
					{

					Stick.SetActive(true);
					Spear.SetActive(false);
					Axe.SetActive(false);

					MoneyMan.Stick = true;
					MoneyMan.Spear = false;
					MoneyMan.Axe = false;

					MoneyMan.Balance -= 5;
					}	
				}

				if (MoneyMan.Balance < 5)
				{

					StartCoroutine("NotEnough");
				}

				if (Stick.activeInHierarchy == true)
				{
					StartCoroutine("AlreadyEquipped");
				}
			}
		}
	}


	public void OnGUI()
	{
		if (isMousedOver == true)
		{
			GUI.Box(new Rect(Screen.width - 200, 150, 150, Screen.height), "Stats \n Name : Stick \n Damage : 1 \n Price : 5 Mun Munz \n Press Space To Buy");
		}
	}

	IEnumerator AlreadyEquipped()
	{
		yield return new WaitForSeconds(0);
		AlreadyEquippedUI.SetActive(true);
		yield return new WaitForSeconds(3);
		AlreadyEquippedUI.SetActive(false);
	}

	IEnumerator NotEnough()
	{
		yield return new WaitForSeconds(0);
		NotEnoughUI.SetActive(true);
		yield return new WaitForSeconds(3);
		NotEnoughUI.SetActive(false);
	}


}
