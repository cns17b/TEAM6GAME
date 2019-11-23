using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameDefeat : MonoBehaviour
{ 
    GameObject[] defeatobjects;
    GameObject[] UIobjects;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        defeatobjects = GameObject.FindGameObjectsWithTag("DefeatMenu");
        UIobjects = GameObject.FindGameObjectsWithTag("UI");
        Defeat();
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
    public void Defeat()
    {
        foreach (GameObject g in defeatobjects)
        {
            g.SetActive(true);
        }
        foreach (GameObject j in UIobjects)
        {
            j.SetActive(false);
        }
    }
  
    //loads inputted level
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        //Application.LoadLevel(level);
    }
}
