using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaivour : MonoBehaviour
{

    public void Play_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_Button()
    {
        Application.Quit();
    }

    public void Shop_Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu_Button()
    {
        SceneManager.LoadScene(0);
    }

}
