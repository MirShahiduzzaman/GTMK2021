using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percent_Update : MonoBehaviour
{   
    public Text changeto;
    public GameObject change;
    private float FE_percent = 100f;
    public PickUpController o;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            changeText();
        }
    }

    void changeText()
    {
        if(o.equipped)
        {
            FE_percent -= 10;
            change.GetComponent<Text>().text = "Fire Extinguisher : " + FE_percent.ToString();
        }
    }
}

