using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetcManagerGameOver : MonoBehaviour
{
    public GameObject transition;


    private void Update()
    {
        AllCollected();
    }


    public void AllCollected()
    {
        if (transform.childCount == 0)
        {
            //levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 2);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
}
