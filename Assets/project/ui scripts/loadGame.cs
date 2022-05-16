using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{

    public void loadScene(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void Exit()
    {
        Application.Quit();
    }  
}
