using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaShrink : MonoBehaviour
{
    public float shrinkSpeed = 0.1f;
    public TMP_Text text;

    void Update()
    {
        this.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(-50, 0, -50), Time.deltaTime * shrinkSpeed);
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Triggered");
        // Destroy a player that leaves the arena
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);

            text.enabled = true;
            if (other.name == "Player1")
            {
                text.text = "Player 2 Wins!";
            }
            if (other.name == "Player2")
            {
                text.text = "Player 1 Wins!";
            }
            StartCoroutine(EndGame());
        }
    }

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Win Screen");
    }
    */
}