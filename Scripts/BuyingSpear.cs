using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingSpear : MonoBehaviour {

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
				if (25 <= MoneyMan.Balance)
				{
					if (Spear.activeInHierarchy == false)
					{

						MoneyMan.Spear = true;
						MoneyMan.Stick = false;
						MoneyMan.Axe = false;

						Spear.SetActive(true);
						Stick.SetActive(false);
						Axe.SetActive(false);

						MoneyMan.Balance -= 25;
					}
				}

				if (MoneyMan.Balance < 25)
				{
					StartCoroutine("NotEnough");
				}

				if (Spear.activeInHierarchy == true)
				{
					StartCoroutine("AlreadyEquipped");
				}
			}
		}
	}

	public void OnGUI()
	{
		if(isMousedOver == true)
		{
			GUI.Box(new Rect(Screen.width - 200, 150, 150, Screen.height), "Stats \n Name : Spear \n Damage : 3 \n Price : 25 Mun Munz \n Press Space To Buy");
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