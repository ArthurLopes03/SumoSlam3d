using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush2 : MonoBehaviour
{
    //[SerializeField] private string inputPushButton;

    private float PushButton;

    public float pushForce = 10f; // Adjust this value to control the strength of the push.


    void Update()
    {
        //PushButton = Input.GetAxisRaw(inputPushButton);
    }

    void OnCollisionStay(Collision collision)
    {
        Rigidbody otherRB1 = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB1 != null && Input.GetButton("Fire2"))
        {
            // Calculate the direction from this object to the other object.
            Vector3 direction = collision.transform.position - transform.position;

            // Normalize the direction vector to ensure it only has a magnitude of 1.
            direction.Normalize();

            // Apply the force in the opposite direction to push the other object.
            otherRB1.AddForce(direction * pushForce, ForceMode.Impulse);
        }
    }
}