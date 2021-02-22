using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelController : MonoBehaviour
{
    public void RestartLevel()
    {

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
