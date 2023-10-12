using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapScript : MonoBehaviour
{
    Movement m;
    public Rigidbody rb;
    public float SlapForce = 1f;

    public bool Slap = false;

    void Start()
    {
        //rb = m.GetComponent<rb>;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            Debug.Log("Enter");
            Slap = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(Slap == true && Input.GetKeyDown("space"))
        {
            Debug.Log("Click");
            rb.AddForce(Vector3.back * SlapForce, ForceMode.Impulse);
        }
    }

    void OnTriggerExit(Collider other)
    {

    }

}
