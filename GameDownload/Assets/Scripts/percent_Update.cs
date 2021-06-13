using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percent_Update : MonoBehaviour
{   
    public Text changeto;
    public GameObject change;
    public float FE_percent = 90f;
    public PickUpController o;

    // Start is called before the first frame update
    void Start()
    {

    }

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
            changeto.text = "Fire Extinguisher : ";
            change.GetComponent<Text>().text = "Fire Extinguisher : " + FE_percent.ToString();
        }
    }
}

