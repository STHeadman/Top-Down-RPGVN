using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public Rigidbody2D RB;

    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        RB.angularVelocity = 0;

        float input = Input.GetAxis("Vertical");
        RB.AddForce(gameObject.transform.up * speed * input);
    }
}
