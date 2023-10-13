using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Killed");
        if(other.tag == "Player")
            SceneManager.LoadScene(2);
    }
}
