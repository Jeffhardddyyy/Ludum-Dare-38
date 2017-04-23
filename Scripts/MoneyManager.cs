using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyManager : MonoBehaviour {

	public int Balance;
	public Text BalanceMoney;

	[Header("Weapons")]
	public bool Stick;
	public bool Spear = false;
	public bool Axe = false;


	//checks


	private void Update()
	{
		if (Balance <= 0)
		{
			Balance = 0;
		}

		BalanceMoney.text = "" + Balance;
	}
}
