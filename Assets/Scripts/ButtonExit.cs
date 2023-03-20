using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonExit : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas ChooseClassMenu;
    public void Exit()
    {
        Application.Quit();
    }
    public void NewGame(int _scene)
    {
        SceneManager.LoadScene(_scene); 
    }
}
