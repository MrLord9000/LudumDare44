using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LaunchLevel1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");//level1
    }
    public void LaunchLevel2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");//level2
    }
    public void LaunchLevel3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");//level3
    }
}
