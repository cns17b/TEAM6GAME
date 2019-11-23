using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamepause : MonoBehaviour
{

    //Menus based on code from https://www.sitepoint.com/adding-pause-main-menu-and-game-over-screens-in-unity/

    GameObject[] pauseobjects;
    GameObject[] UIobjects;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseobjects = GameObject.FindGameObjectsWithTag("PauseMenu");
        UIobjects = GameObject.FindGameObjectsWithTag("UI");
        Unpause();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            {
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    Pause();
                }
                else if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    Unpause();
                }
            }
        }
    }

    //Restart Level
    public void Restart()
    {
        SceneManager.LoadScene("EndlessLevel");
        //Application.LoadLevel(Application.loadedLevel);
    }

    //Pause the game
    public void pauseGame()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Pause();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Unpause();
        }
    }

    //Show pause menu on pause
    public void Pause()
    {
        foreach (GameObject g in pauseobjects)
        {
            g.SetActive(true);
        }
        foreach (GameObject j in UIobjects)
        {
            j.SetActive(false);
        }
    }
    //Hide pause menu on pause
    public void Unpause()
    {
        foreach (GameObject g in pauseobjects)
        {
            g.SetActive(false);
        }
        foreach (GameObject j in UIobjects)
        {
            j.SetActive(true);
        }
    }

    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
}
