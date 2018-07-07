using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OpenLockerTrigger : MonoBehaviour {

    public static Action OpenLocker;
    public static Action CloseLocker;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            OpenLocker();
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "OS" || other.tag == "IS")
        {
            CloseLocker();
        }

    }
}
