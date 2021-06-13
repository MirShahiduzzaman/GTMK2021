using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen : MonoBehaviour
{

    private bool mouseDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {  
        //Load a scene by the name "SceneName" if you press the W key.
        if(Input.GetKeyDown(KeyCode.W))
        {
            Application.LoadLevel(0);
        }        
    }

    private void OnMouseOver()
    {
        Debug.Log(enabled);
        if (!enabled)
        {
            Debug.Log("Disabled");
            return;
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(1);
                Debug.Log("Clicked on screen");
            }
        }
    }
}
