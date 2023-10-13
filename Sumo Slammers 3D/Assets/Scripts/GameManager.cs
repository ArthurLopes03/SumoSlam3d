using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    string winner;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Killed");
        if (other.name == "Player 1")
        {
            SceneManager.LoadScene(2);
            /*
            if(other.name == "Player1")
            {
                winner = "Player 2";
            }
            else if (other.name == "Player2")
            {
                winner = "Player 1";
            }*/
        }
        if (other.name == "Player 2")
        {
            SceneManager.LoadScene(3);
        }

    }
}
