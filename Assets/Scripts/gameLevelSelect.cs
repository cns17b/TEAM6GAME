using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameLevelSelect : MonoBehaviour
{
    //Assets/Plugins/WebGL/ImageUploader.jslib

    //Menus based on code from https://www.sitepoint.com/adding-pause-main-menu-and-game-over-screens-in-unity/

    GameObject[] Menuobjects;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Menuobjects = GameObject.FindGameObjectsWithTag("LevelSelect");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
}
