using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{
    public Rigidbody rb;
    
    public float chargeSpeed = 10f;
    public float chargeDuration = 1.0f;

    public float bounceForce = 10f;
    
    private bool isCharging = false;
    private bool hitTarget = false;
    
    private Vector3 chargeDirection;

    void Update()
    {
        if (Input.GetKeyDown("space") && !isCharging)
        {
            //Debug.Log("Charging");
            chargeDirection = transform.forward;
            StartCoroutine(Charge());

            hitTarget = true;
        }
    }

    private IEnumerator Charge()
    {
        isCharging = true;
        
        float startTime = Time.time;
        float elapsedTime = 0f;

        while (elapsedTime < chargeDuration)
        {
            float fraction = elapsedTime / chargeDuration;
            Vector3 newPosition = transform.position + chargeDirection * chargeSpeed * Time.deltaTime;
            rb.MovePosition(newPosition);
            elapsedTime = Time.time - startTime;
            yield return null;
        }

        isCharging = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody PushRb = collision.gameObject.GetComponent<Rigidbody>();

        if (PushRb != null && hitTarget == true)
        {
            Vector3 direction = collision.transform.position - transform.position;

            direction.Normalize();

            PushRb.AddForce(direction * bounceForce, ForceMode.Impulse);
        }
    }
}
