using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    //Attach this to a collider that will be used for knockback attacks, when the animation is played it will enable the collider
    public float pushForce = 10f;


    //Code was mostly coppied from player push script
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Detected " + collision.gameObject.name);
        Rigidbody otherRB = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB.transform.root == this.transform.root)
        {
            Debug.Log(collision.gameObject.name + " shares same parent");
            return;
        }


        if (otherRB != null && otherRB.gameObject.tag == "Player")
        {
            Debug.Log("Colliding");
            Vector3 direction = collision.transform.position - transform.position;

            direction.Normalize();

            otherRB.AddForce(direction * pushForce, ForceMode.Impulse);
        }
    }
}
