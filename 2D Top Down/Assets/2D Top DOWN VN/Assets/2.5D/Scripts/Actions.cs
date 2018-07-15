using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Actions : MonoBehaviour {

    public static Action<float> XMoveAction;
    public static Action<float> ZMoveAction;

    // Update is called once per frame
    void Update()
    {
        if (XMoveAction != null)
        {
            XMoveAction(Input.GetAxis("Horizontal"));
        }
            if (ZMoveAction != null)
        {
            ZMoveAction(Input.GetAxis("Vertical"));
        }
      }
    }
