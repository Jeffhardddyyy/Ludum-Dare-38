using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManager : MonoBehaviour {

	public Text HungerLevelNUM;
	public int HungerLevel;
	public PlayerManager PM;
	


	private void Start()
	{
		StartCoroutine("IncreaseHunger");
	}

	private void Update()
	{
		HungerLevelNUM.text = "" + HungerLevel;


		if(HungerLevel <= 0)
		{
			HungerLevel = 1;
		}
	}

	IEnumerator IncreaseHunger()
	{
		yield return new WaitForSeconds(20 - PM.SaturationXP);


		if(HungerLevel < 10)
		{
		HungerLevel++;
		}

		if(HungerLevel == 10)
		{
			PM.Health = PM.Health - 2;
		}
		

		StartCoroutine("IncreaseHunger");
	}

}
