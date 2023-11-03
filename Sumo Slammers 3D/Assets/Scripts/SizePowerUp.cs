using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePowerUp : MonoBehaviour
{
    public float sizeMultiplier = 1.5f;
    public float duration = 10f;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            StartCoroutine (Pickup(other));
        }
        
    }

    IEnumerator Pickup(Collider player)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);
        player.transform.localScale *= sizeMultiplier;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        player.transform.localScale /= sizeMultiplier;

        Destroy(gameObject);
    }
}
