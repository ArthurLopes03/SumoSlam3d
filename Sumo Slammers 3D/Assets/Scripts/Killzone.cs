using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Killed");
        if (other.name == "Player 1")
        {
            SceneManager.LoadScene(2);
        }

        if (other.name == "Player 2")
        {
            SceneManager.LoadScene(3);
        }
    }
}
