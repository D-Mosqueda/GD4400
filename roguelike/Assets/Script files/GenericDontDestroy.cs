using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GenericDontDestroy : MonoBehaviour
{
    //Scene currentScene = SceneManager.GetActiveScene();
    //string sceneName = SceneManager.GetActiveScene().name;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Main Menu")
        {
            Destroy(gameObject);
        }
       
    }

}
