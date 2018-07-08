using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISSchoolBarrier : MonoBehaviour {
    public GameObject Message;
    public GameObject Wall;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "OS")
        {
            Wall.SetActive(false);
        } else if (other.gameObject.tag == "IS")
        {
            Message.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        Wall.SetActive(true);
        Message.SetActive(false);
    }
}
