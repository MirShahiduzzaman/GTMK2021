using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseCheck : MonoBehaviour
{
    public Text winLose;
    public GameObject depends;
    public PickUpController o;
    private string result = "";
    public progress_slider_ temp;
    public progress_slider_ goal;

    // Update is called once per frame
    void Update()
    {
        check();
    }

    void check()
    {
        if(temp.slider.value == 1)
        {
            Time.timeScale = 0;
            Debug.Log("You lost... Try again? (Restart the app)");
        }
        else if(goal.slider.value == 1)
        {
            Time.timeScale = 0;
            Debug.Log("You Won! Congrats!!");
        }
        depends.GetComponent<Text>().text = result;
    }
}
