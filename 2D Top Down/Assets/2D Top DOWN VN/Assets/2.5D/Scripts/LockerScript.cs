using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerScript : MonoBehaviour {

    public GameObject Player;
    public GameObject Sprite;

    void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<MovementScript>().speed = 3.0f;
        
    }
}
