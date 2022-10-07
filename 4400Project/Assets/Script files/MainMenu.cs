using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject CreditsMenu;




    //Changes from start menu to scene 1. Note this changes to scene 1 so if level 1 is not scene 1 it will not switch to it. Ensure level 1 is scene 1 in build order
   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    //quits the game
    public void QuitGame()
    {
        Application.Quit();
    }


    //Credits menu is an overlay panel on top of the Start Menu. These two functions set active state.
    public void OpenCredits()
    {
        CreditsMenu.SetActive(true);
    }

    public void CloseCredits()
    {
        CreditsMenu.SetActive(false);
    }

   
   
}
