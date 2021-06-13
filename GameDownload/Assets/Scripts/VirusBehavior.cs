using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusBehavior : MonoBehaviour
{
    public GameObject targ;
    public int health = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targ.transform.position, .001f);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked on virus");
            health--;
            if (health == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                gameObject.transform.Rotate(0, 0, Random.Range(-90, 90), Space.Self);
            }
            
        }
    }
}
