using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ATTACK : MonoBehaviour
{

	[Header("Animations")]
	public Animation StickAttack;
	public Animation SpearAttack;
	public Animation AxeAttack;

	[Space]
	public MoneyManager Weapons;


	private void Start()
	{
		Weapons.Stick = true;
	}

	private void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			if (Weapons.Stick == true)
			{
				StickAttack.wrapMode = WrapMode.Once;
				StickAttack.Play("SAttack", PlayMode.StopAll);
			}

			if (Weapons.Spear == true)
			{
				SpearAttack.wrapMode = WrapMode.Once;
				SpearAttack.Play("Spear_Attack", PlayMode.StopAll);
			}

			if(Weapons.Axe == true)
			{
				AxeAttack.wrapMode = WrapMode.Once;
				AxeAttack.Play("Axe_Attack", PlayMode.StopAll);

			}
		}
	}

}