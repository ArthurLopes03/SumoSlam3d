using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    bool inCollider = false;
    Rigidbody _otherRb;

    Vector3 _direction;

    public float _knockBackForce = 20;

    void OnTriggerEnter(Collider other)
    {
        inCollider = true;
    }

    void OnTriggerStay(Collider other)
    {

        if (other.attachedRigidbody)
        {
            _otherRb = other.attachedRigidbody;
            print(other.name);
            _direction = _otherRb.position - transform.position;
            _direction.y = 2;

            if (Input.GetMouseButtonDown(0)&& inCollider == true)
            {
                print(_direction * _knockBackForce * Time.deltaTime);
                _otherRb.AddForce(_direction * _knockBackForce * Time.deltaTime, ForceMode.Impulse);
            }
        }
       
    }
    void OnTriggerExit(Collider other)
    {
        inCollider = false;
    }
}
