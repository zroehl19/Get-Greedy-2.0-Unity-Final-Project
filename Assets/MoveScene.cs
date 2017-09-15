using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour 
{
	public GameObject guiObject;
	public string loadLevel;

	void Start()
	{
		guiObject.SetActive (false);
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			guiObject.SetActive (true);
			if (guiObject.activeInHierarchy == true && Input.GetButtonDown ("Use"))
			{
				Application.LoadLevel (loadLevel);
			}
		}
	}

	void OnTriggerExit()
	{
		guiObject.SetActive (false);
	}
}
