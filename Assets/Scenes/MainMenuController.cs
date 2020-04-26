using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Работа с интерфейсами
using UnityEngine.SceneManagement; //Работа со сценами
using UnityEngine.Audio; //Работа с аудио
public class MainMenuController : MonoBehaviour
{

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
           
            SceneManager.LoadScene("Menu");
            
            Time.timeScale = 0;
        }
else
{

 Time.timeScale = 1;
}
	}
}
