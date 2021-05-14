using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void LoadGame()
    {
        //load Game scene
        SceneManager.LoadScene(1); //Game Scene
    }
}
