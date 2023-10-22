using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{
    /*
    public Rigidbody rb;

    public float ChargeSpeed = 10f;

    private void Update()
    {
        //Debug.Log("Tf is happening to VS Code");

        if(Input.GetKeyDown("space"))
        {
            Debug.Log("Should Work");

            Vector3 chargeDirection = transform.forward;

            chargeDirection.Normalize();

            rb.AddForce(chargeDirection * ChargeSpeed, ForceMode.Impulse);
        }
    }
    */
    public Rigidbody rb;
    
    public float chargeSpeed = 10f;
    public float chargeDuration = 1.0f;
    
    private bool isCharging = false;
    
    private Vector3 chargeDirection;

    void Update()
    {
        if (Input.GetKeyDown("space") && !isCharging)
        {
            //Debug.Log("Charging...");
            chargeDirection = transform.forward;
            StartCoroutine(Charge());
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
}
