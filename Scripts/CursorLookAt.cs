using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLookAt : MonoBehaviour
{

	public bool showCursor;
	public float Sensitivity;

	[Space]
	public PauseMenuManager PauseManager;
	private bool isPaused;


	private void Start()
	{
		Cursor.visible = false;
	}


	private void Update()
	{
		isPaused = PauseManager.isPaused;

		if (PauseManager.isPaused == false)
		{

			float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity;
			float newRotationX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * Sensitivity;

			gameObject.transform.localEulerAngles = new Vector3(newRotationX, newRotationY, 0);
		}
	}
}
