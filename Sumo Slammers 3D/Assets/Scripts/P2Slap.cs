using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Slap : MonoBehaviour
{
    private bool isCollided = false;
    public Rigidbody OtherRb;
    public float pushForce = 7.5f;

     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            isCollided = true;
        }
    }

    void ResetCollision()
    {
        isCollided = false;
    }

    void FixedUpdate()
    {

        if (isCollided == true)
        {
            Vector3 direction = -transform.forward;

            //direction.Normalize();

            OtherRb.AddForce(direction * pushForce, ForceMode.Impulse);

            ResetCollision();
        }
    }
}
