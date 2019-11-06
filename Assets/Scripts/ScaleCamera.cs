using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCamera : MonoBehaviour
{
    //This Code was demonstrated in a youtube tutorial on adjusting the game to work for multiple resolutions.  The tutorial followed is here: https://www.youtube.com/watch?v=TYNF5PifSmA
    public bool maintainWidth = true;
    private float defaultWidth;
    private float defaultHeight;
    private Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = Camera.main.transform.position;
        defaultHeight = 16.5f;
        defaultWidth = 16.5f*Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (maintainWidth)
        {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
            Camera.main.transform.position = new Vector3(-1 * (defaultWidth - Camera.main.orthographicSize*Camera.main.aspect), -1 * (defaultHeight - Camera.main.orthographicSize), cameraPosition.z);
        }
       
        
    }
}
