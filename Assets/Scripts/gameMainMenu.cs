using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMainMenu : MonoBehaviour
{
    //Menus based on code from https://www.sitepoint.com/adding-pause-main-menu-and-game-over-screens-in-unity/

    GameObject[] Menuobjects;
    GameObject[] ComingSoonobjects;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Menuobjects = GameObject.FindGameObjectsWithTag("MainMenu");
        ComingSoonobjects = GameObject.FindGameObjectsWithTag("ComingSoon");
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Load Level Select
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
        //Application.LoadLevel(Application.loadedLevel);
    }



    //Show coming soon menu for undeveloped features
    public void ComingSoon()
    {
        foreach (GameObject j in ComingSoonobjects)
        {
            j.SetActive(true);
        }
        foreach (GameObject g in Menuobjects)
        {
            g.SetActive(false);
        }

    }


    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
}
