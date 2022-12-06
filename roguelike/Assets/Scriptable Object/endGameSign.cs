using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endGameSign : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;
    public bool playerInRange;
    float waitTime = 5;

    //bool isCoroutineReady = false;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            /*if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {*/
            //isCoroutineReady = true;
                //Time.timeScale = 0f;
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            StartCoroutine(endGame());


            //}
        }
    }

    IEnumerator endGame()
    {
        //if (dialogBox.activeInHierarchy)
        //{
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(0);
            //Time.timeScale = 1f;
        //}
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
