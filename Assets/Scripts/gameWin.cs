using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameWin : MonoBehaviour
{
    //Assets/Plugins/WebGL/ImageUploader.jslib
    GameObject[] winobjects;
    //GameObject[] UIobjects;
    // Start is called before the first frame update
    void Start()
    {
        
        winobjects = GameObject.FindGameObjectsWithTag("VictoryMenu");
       // UIobjects = GameObject.FindGameObjectsWithTag("UI");
        Win();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Restart Level
    public void Restart()
    {
        SceneManager.LoadScene("EndlessLevel");
        //Application.LoadLevel(Application.loadedLevel);
    }



    //Show defeat menu
    public void Win()
    {
        foreach (GameObject g in winobjects)
        {
            g.SetActive(true);
        }
       // foreach (GameObject j in UIobjects)
        //{
         //   j.SetActive(false);
        //}
    }

    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
}
