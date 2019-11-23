using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComingSoon : MonoBehaviour
{
    //Menus based on code from https://www.sitepoint.com/adding-pause-main-menu-and-game-over-screens-in-unity/

    GameObject[] Menuobjects;
    GameObject[] ComingSoonobjects;
    // Start is called before the first frame update
    void Start()
    {
        Menuobjects = GameObject.FindGameObjectsWithTag("MainMenu");
        ComingSoonobjects = GameObject.FindGameObjectsWithTag("ComingSoon");
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Go back to main menu
    public void Back()
    {
        foreach (GameObject j in Menuobjects)
        {
            j.SetActive(true);
        }
        foreach (GameObject g in ComingSoonobjects)
        {
            g.SetActive(false);
        }
    }
}
