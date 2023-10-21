using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{
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
}
