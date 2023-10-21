using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    //[SerializeField] private string inputPushButton;

    private float PushButton;

    public float pushForce = 10f;
    

    void Update()
    {
        //PushButton = Input.GetAxisRaw(inputPushButton);
    }

    void OnCollisionStay(Collision collision)
    {
        Rigidbody otherRB = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB != null && Input.GetButton("Fire1Xbox"))
        {
            Vector3 direction = collision.transform.position - transform.position;

            direction.Normalize();

            otherRB.AddForce(direction * pushForce, ForceMode.Impulse);
        }
    }
}

