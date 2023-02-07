using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    //S�lection al�atoire d'une scene
    /*
    int nextSceneIndex = Random.Range(0, 4);
    SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Single);
    */

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(int index)
    {
        {
            SceneManager.LoadScene(index);
        }
    }

    public void LoadPreviousScene()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }
}
