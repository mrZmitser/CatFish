using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Работа с интерфейсами
using UnityEngine.SceneManagement; //Работа со сценами
using UnityEngine.Audio; //Работа с аудио


public class MainMenu : MonoBehaviour
{


public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }
public void ContinuePressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
