using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}