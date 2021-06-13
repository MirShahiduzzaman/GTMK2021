using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    GameObject mainCamera;
    bool carrying;
    GameObject carriedObject;
    public float distance;
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if(carrying)
        {
            Carry(carriedObject);
            CheckDrop();
        }
        else
        {
            Pickup();
        }
    }

    void RotateObject()
    {
        carriedObject.transform.Rotate(5,10,15);
    }

    void Carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward*distance, Time.deltaTime*smooth);
    }

    void Pickup()
    {
        if(Input.GetMouseButtonDown(1))
        {
            int x = Display.main.systemWidth/2;
            int y = Display.main.systemHeight/2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y,0));
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if(p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }

    void CheckDrop()
    {
        if(Input.GetMouseButtonDown(1))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject = null;
    }
}
