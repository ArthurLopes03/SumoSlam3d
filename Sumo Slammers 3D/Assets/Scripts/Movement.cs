using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;

    //[SerializeField] private Color color;

    Rigidbody rb;
    //private Renderer renderer;

    private float inputHorizontal;
    private float inputVertical;

    public float rotationSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //renderer = GetComponentInChildren<Renderer>();
        //renderer.material.color = color;
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);

        Vector3 movementDirection1 = new Vector3(inputHorizontal, 0, inputVertical);
        movementDirection1.Normalize();

        //transform.Translate(movementDirection1 * Time.deltaTime, Space.World);

        if (movementDirection1 != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection1, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        rb.velocity = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);
    }
}
