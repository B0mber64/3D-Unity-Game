using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{

    public GameObject winScreenUI;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        Cursor.lockState = CursorLockMode.None;
        winScreenUI.SetActive(true);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
