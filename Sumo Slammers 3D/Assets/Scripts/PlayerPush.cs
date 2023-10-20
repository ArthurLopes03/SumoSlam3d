using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
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
        Rigidbody otherRB = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB != null && Input.GetButton("Fire1"))
        {
            // Calculate the direction from this object to the other object.
            Vector3 direction = collision.transform.position - transform.position;

            // Normalize the direction vector to ensure it only has a magnitude of 1.
            direction.Normalize();

            // Apply the force in the opposite direction to push the other object.
            otherRB.AddForce(direction * pushForce, ForceMode.Impulse);
        }
    }
}

