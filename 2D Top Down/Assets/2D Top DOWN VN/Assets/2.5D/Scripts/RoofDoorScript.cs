using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDoorScript : MonoBehaviour {

    // Use this for initialization
    public Animator RoofDoor;
    public GameObject Interact;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            Interact.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                RoofDoor.SetTrigger("OpenD");
                RoofDoor.ResetTrigger("CloseD");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            Interact.SetActive(false);
            RoofDoor.SetTrigger("CloseD");
            RoofDoor.ResetTrigger("OpenD");
        }
    }
}
