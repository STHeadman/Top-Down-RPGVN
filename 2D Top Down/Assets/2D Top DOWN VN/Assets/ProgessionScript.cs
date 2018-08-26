using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgessionScript : MonoBehaviour {

    public GameObject[] players;
    GameObject currentplayer;
    int playerIndex;

    // Use this for initialization
    void Start () {

        playerIndex = 0;
        currentplayer = players[playerIndex];
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if (playerIndex == players.Length)
            {
                playerIndex = 0;
            }
            playerIndex++;
            players[playerIndex].gameObject.SetActive(true);
            Debug.Log(playerIndex);
        } else if (Input.GetMouseButtonDown(1))
        {
            if (playerIndex == players.Length)
            {
                playerIndex = 0;
            }
            playerIndex--;
            players[playerIndex].gameObject.SetActive(false);
            Debug.Log(playerIndex);
        }

    }
}
