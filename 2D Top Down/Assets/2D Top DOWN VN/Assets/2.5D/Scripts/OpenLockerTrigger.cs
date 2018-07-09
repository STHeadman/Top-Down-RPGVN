using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLockerTrigger : MonoBehaviour {

    public Animator Door;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            Door.SetTrigger("Open");
            Door.ResetTrigger("Close");
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            Door.SetTrigger("Close");
            Door.ResetTrigger("Open");
        }

    }
}
