using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public string sceneGame;
	public string sceneOptions;
	public string sceneMenu;
	void Update()
	{
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
		if (Input.GetKey("g"))
		{
			SceneManager.LoadScene(sceneGame);
		}
		if (Input.GetKey("o"))
		{
			SceneManager.LoadScene(sceneOptions);
		}
		if (Input.GetKey("m"))
		{
			SceneManager.LoadScene(sceneMenu);
		}
	}
}