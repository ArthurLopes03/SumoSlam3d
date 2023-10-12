using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    Rigidbody _otherRb;

    Vector3 _direction;

    public float _knockBackForce = 20;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //OnTriggerEnter
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (other.attachedRigidbody)
            {
                _otherRb = other.attachedRigidbody;
                print(other.name);
                _direction = _otherRb.position - transform.position;
                _direction.y = 2;

                print(_direction * _knockBackForce * Time.deltaTime);

                _otherRb.AddForce(_direction * _knockBackForce * Time.deltaTime, ForceMode.Impulse);
            }
        }
    }
}
