using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush2 : MonoBehaviour
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
        Rigidbody otherRB1 = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB1 != null && Input.GetButton("Player2-Test"))
        {
            Vector3 direction = collision.transform.position - transform.position;

            direction.Normalize();

            otherRB1.AddForce(direction * pushForce, ForceMode.Impulse);
        }
    }
}