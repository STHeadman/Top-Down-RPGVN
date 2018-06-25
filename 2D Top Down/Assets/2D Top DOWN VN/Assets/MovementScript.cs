using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    
    Material Mats;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController cc;
    GameObject player;
    public SpriteRenderer sprite;

    void Start()
    {
        Mats = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }

    void Update()
    {
         cc = GetComponent<CharacterController>();
        if (cc.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            ColorChange();
       
        }
        moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * Time.deltaTime);
        


    }

    void ColorChange()
    {
        if (moveDirection.x > 1)
        {
            Mats.color = Color.blue;
        }

        else if (moveDirection.z > 1)
        {
            Mats.color = Color.black;
        }
        else if (-moveDirection.z > 1)
        {
            Mats.color = Color.white;
        }

        else if (-moveDirection.x > 1)
        {
            Mats.color = Color.yellow;
        }
    }

   void OnMouseOver()
    {
        Mats.color = Color.white;
    }

   void OnMouseExit()
    {
        Mats.color = Color.red;
    }
}