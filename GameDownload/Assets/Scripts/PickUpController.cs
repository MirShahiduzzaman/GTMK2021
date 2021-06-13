using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public Pickupable o;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, objectContainer, fpsCam;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    private int x;
    private int y;


    // Start is called before the first frame update
    void Start()
    {
        x = Display.main.systemWidth/2;
        y = Display.main.systemHeight/2;
        if(!equipped)
        {
            o.enabled = false;
            rb.isKinematic = false;
            coll.isTrigger = false;
        }
        else
        {
            o.enabled = true;
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // checks if player is in range and right mouse 
        // is pressed
        //Vector3 distanceToPlayer = player.position - transform.position;
        Ray ray = fpsCam.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y,0));
        RaycastHit hit;
        // if()
        // {
        //     Pickupable p = hit.collider.GetComponent<Pickupable>();
        //     if(p != null)
        //     {
        //         carrying = true;
        //         carriedObject = p.gameObject;
        //         p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //     }
        // }

        if(!equipped && Physics.Raycast(ray, out hit) && Input.GetKeyDown(KeyCode.E) && !slotFull) //(!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
        {
            Pickupable p = hit.collider.GetComponent<Pickupable>();
            if(p != null)
            {
                PickUp();
            }
        }

        if(equipped && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }
    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;

        // Make object a child of the camera and move to default position
        transform.SetParent(objectContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;

        // Make Rigidbody kinematic and Boxcollider a trigger
        rb.isKinematic = true;
        coll.isTrigger = true;

        // Enable script
        o.enabled = true;
    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;

        // Set parent to null
        transform.SetParent(null);

        // Make Rigidbody kinematic and Boxcollider a trigger
        rb.isKinematic = false;
        coll.isTrigger = false;

        // Enable script
        o.enabled = false;
    }
}
