using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
	//attatch to game manager
	[Header("Enemy Types")]
	public GameObject Enemy1;
	public GameObject Enemy2;
	public GameObject Enemy3;

	[Space]
	public GameObject BOSS;


	private void Start()
	{
		StartCoroutine("Generate");
		StartCoroutine("GenerateBoss");
	}



	IEnumerator Generate()
	{

		yield return new WaitForSeconds(5);

		//ints for Generate
		int TypeOfEnemy = Random.Range(1, 4);            //decides the type of enemy
		int NESW = Random.Range(1, 4);      //declare if it should spawn on top, left, bottom, or right of the island

		if (TypeOfEnemy == 1)
		{
			if (NESW == 1)                          //x			min		max		  y			z		min		max
			{//top
				Instantiate(Enemy1, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 2)
			{//right
				Instantiate(Enemy1, new Vector3(Random.Range(-37.52f, 50.089f), 1, Random.Range(-20.009f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 3)
			{//down
				Instantiate(Enemy1, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(-10.152f, -19.848f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 4)
			{//left
				Instantiate(Enemy1, new Vector3(Random.Range(-1.7f, -10.54f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
		}

		if (TypeOfEnemy == 2)
		{
			if (NESW == 1)                          //x			min		max		  y			z		min		max
			{//top
				Instantiate(Enemy2, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 2)
			{//right
				Instantiate(Enemy2, new Vector3(Random.Range(-37.52f, 50.089f), 1, Random.Range(-20.009f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 3)
			{//down
				Instantiate(Enemy2, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(-10.152f, -19.848f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 4)
			{//left
				Instantiate(Enemy2, new Vector3(Random.Range(-1.7f, -10.54f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
		}


		if(TypeOfEnemy == 3)
		{
			if (NESW == 1)                          //x			min		max		  y			z		min		max
			{//top
				Instantiate(Enemy3, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 2)
			{//right
				Instantiate(Enemy3, new Vector3(Random.Range(-37.52f, 50.089f), 1, Random.Range(-20.009f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 3)
			{//down
				Instantiate(Enemy3, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(-10.152f, -19.848f)), new Quaternion(0, 0, 0, 1));
			}
			if (NESW == 4)
			{//left
				Instantiate(Enemy3, new Vector3(Random.Range(-1.7f, -10.54f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
			}

		}
		StartCoroutine("Generate");
	}






	IEnumerator GenerateBoss()
	{
		yield return new WaitForSeconds(Random.Range(60, 600));
		int NESW = Random.Range(1, 4);
		if (NESW == 1)                          //x			min		max		  y			z		min		max
		{//top
			Instantiate(BOSS, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
		}
		if (NESW == 2)
		{//right
			Instantiate(BOSS, new Vector3(Random.Range(-37.52f, 50.089f), 1, Random.Range(-20.009f, 48.32f)), new Quaternion(0, 0, 0, 1));
		}
		if (NESW == 3)
		{//down
			Instantiate(BOSS, new Vector3(Random.Range(-16.667f, 50.089f), 1, Random.Range(-10.152f, -19.848f)), new Quaternion(0, 0, 0, 1));
		}
		if (NESW == 4)
		{//left
			Instantiate(BOSS, new Vector3(Random.Range(-1.7f, -10.54f), 1, Random.Range(30.367f, 48.32f)), new Quaternion(0, 0, 0, 1));
		}


		StartCoroutine("GenerateBoss");
	}
}