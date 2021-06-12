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

    

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
            Debug.Log("Clicked on screen");
        }
    }
}
