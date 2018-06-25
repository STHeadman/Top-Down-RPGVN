using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Invoke("Die", 1f);
	}
	
	// Update is called once per frame
    void Die()
    {
        Destroy(gameObject);
    }
}
