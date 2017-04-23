using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	[Header("Player Stats")]
	public int Health = 100;            //the actual health

	[Header("Mouse")]
	public bool showCursor;         //should the cursor be shown?
	public float Sensitivity;       //sensitivity of the mouse speed?

	[Header("Skills")]
	public float MovementSpeed;     //how fast should the player be walking? [SKILL]
	public int AttackDamage;      //how much should damage should be deducted from the enemy when you hit ? [SKILL]
	public float MovementSpeedXP;   //XP FOR MOVEMENTSPEED [SkillAddon]
	public float AttackDamageXP;    //XP FOR ATTACKDAMAGE [SkillAddon]
	public float SaturationXP;		


	public Player_Death PlayerDeath;





	private void Start()
	{//on start
		Health = 100;
		if (showCursor == false)
		{//if "showCursor" is equal to "false"
			Cursor.visible = false;             //make the cursor invisble

			Cursor.lockState = CursorLockMode.Locked;
		}
	}


	private void Update()
	{//every frame..


		if (showCursor == false)
		{//if "showCursor" is equal to "false"
			Cursor.visible = false;             //make the cursor invisble

			Cursor.lockState = CursorLockMode.Locked;
		}


		showCursor = false;


		if (2 <= gameObject.transform.position.y || gameObject.transform.position.y <= -1)
		{//if the player is higher/equal to "2" or lower/equal to "-1"
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1, gameObject.transform.position.z); //reset position
		}


		float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity;     //make new float of camera pos
		float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * Sensitivity;     //make new float of camera pos
		gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);             //have the camera  rotate to that pos
																										//I did make a video explaining that ^^^^



		//movement

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{//if "W" or "UpArrow" is pressed / held down
			gameObject.transform.Translate(0, 0, MovementSpeed);                  //move
			MovementSpeedXP = MovementSpeedXP + 0.0001f;

			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				gameObject.transform.Translate(0, 0, MovementSpeed * MovementSpeedXP);                  //"sprint"
			}
		}

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{//if "A" or "LeftArrow" is pressed / held down
			gameObject.transform.Translate(MovementSpeed * -1, 0, 0);             //move
			if (MovementSpeedXP < 0.04)
			{
				MovementSpeedXP = MovementSpeedXP + 0.0001f;
			}


			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				gameObject.transform.Translate(MovementSpeed * MovementSpeedXP * -1, 0, 0);                  //"sprint"
			}

		}

		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{//if "S" or "DownArrow" is pressed / held down
			gameObject.transform.Translate(0, 0, MovementSpeed * -1);             //move
			if (MovementSpeedXP < 0.04)
			{
				MovementSpeedXP = MovementSpeedXP + 0.0001f;
			}


			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				gameObject.transform.Translate(0, 0, MovementSpeed * MovementSpeedXP * -1);                  //"sprint"
			}

		}	

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{//if "D" or "RightArrow" is pressed / held down
			gameObject.transform.Translate(MovementSpeed, 0, 0);                  //move

			if(MovementSpeedXP < 0.04)
			{
			MovementSpeedXP = MovementSpeedXP + 0.0001f;
			}

			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				gameObject.transform.Translate(MovementSpeed * MovementSpeedXP, 0, 0, 0);                  //"sprint"
			}

		}

		if(Health <= 0)
		{
			PlayerDeath.isDead = true;
		}
	}
}
