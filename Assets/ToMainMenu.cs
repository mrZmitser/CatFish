using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToMainMenu : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ToMenu);
    }
    public void ToMenu()
    {
        var saveManager = GameObject.Find("Saving").GetComponent<SaveManager>();
        saveManager.isGameStarted = false;
        SceneManager.LoadScene("Menu");
    }

}
