using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
