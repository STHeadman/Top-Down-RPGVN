using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    public GameObject explosion;

    public GameObject Enemy;

    void OnTriggerEnter2D (Collider2D other)
    {
        //Enemy.SetActive(false);
        Instantiate(explosion, other.transform.position, Quaternion.identity);
        Destroy (other.gameObject);
    }
}
