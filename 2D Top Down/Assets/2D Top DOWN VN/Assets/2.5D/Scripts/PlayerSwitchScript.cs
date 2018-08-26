using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitchScript : MonoBehaviour
{

    public GameObject[] players;
    GameObject currentplayer;
    public GameObject interact;
    int playerIndex;


    // Use this for initialization
    void Start()
    {
        playerIndex = 0;
        currentplayer = players[0];
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerIndex++;
            if (playerIndex == players.Length)
            {
                playerIndex = 0;
            }
            currentplayer.GetComponent<CharacterController>().enabled = false;
            currentplayer.GetComponent<MovementScript>().enabled = false;
            currentplayer.gameObject.SetActive(false);
            players[playerIndex].GetComponent<CharacterController>().enabled = true;
            players[playerIndex].GetComponent<MovementScript>().enabled = true;
            players[playerIndex].gameObject.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraFollow>().player = players[playerIndex].gameObject;
            currentplayer = players[playerIndex];
        }
    }

    void OnTriggerEnter()
    {
        interact.SetActive(true);
    }

    void OnTriggerExit()
    {
        interact.SetActive(false);
    }
}
