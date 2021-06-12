using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bug_slider_ : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 0;
    public float fillspeed = 0.1f;

    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        incrementProgress(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value < targetProgress){
            slider.value += fillspeed*Time.deltaTime/10;//devide by number (10 for now) to slow the progress bar
        }
    }

    //Add progress to the bar
    public void incrementProgress(float newProgress){
        targetProgress = slider.value + newProgress;
    }
}

