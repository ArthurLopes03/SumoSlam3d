using UnityEngine;

public class PlayerPush : MonoBehaviour
{

    public float pushForce = 10f; // Adjust this value to control the strength of the push.
    
    void OnCollisionStay(Collision collision)
    {
        Rigidbody otherRB = collision.gameObject.GetComponent<Rigidbody>();

        if (otherRB != null)
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

