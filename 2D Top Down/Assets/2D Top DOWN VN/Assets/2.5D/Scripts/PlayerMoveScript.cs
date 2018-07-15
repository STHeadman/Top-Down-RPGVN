using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
public class PlayerMoveScript : MonoBehaviour {



        CharacterController cc;

        Vector3 tempMove;

        private Action OnLandAction;

        public float speed = 6;
        public float gravity = 20;


        // Use this for initialization
        void Start()
        {

            cc = GetComponent<CharacterController>();
            Actions.XMoveAction += Movex;
            Actions.ZMoveAction += Movez;
        Debug.Log("hey");

    }

    private void Movez(float _movement)
    {


        tempMove.z = _movement * speed;
        cc.Move(tempMove * Time.deltaTime);

        if (!cc.isGrounded)
        {
            tempMove.y -= gravity * Time.deltaTime;
            if (OnLandAction == null)
            {
                OnLandAction += restGravity;
            }
        }
        if (cc.isGrounded)
        {
            if (OnLandAction != null)
            {
                OnLandAction();
                OnLandAction = null;
            }
        };
    }

    void Update()
    {

    }

        // Update is called once per frame
        void Movex(float _movement)
            {
            

            tempMove.x =_movement * speed;
            cc.Move(tempMove * Time.deltaTime);

            if (!cc.isGrounded)
            {
                tempMove.y -= gravity * Time.deltaTime;
                if (OnLandAction == null)
                {
                    OnLandAction += restGravity;
                }
            }
            if (cc.isGrounded)
            {
                if (OnLandAction != null)
                {
                    OnLandAction();
                    OnLandAction = null;
                }
            }
        }

        void restGravity()
        {
            tempMove.y = -.1f;
        }
    }
