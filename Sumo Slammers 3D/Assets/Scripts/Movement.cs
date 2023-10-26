using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Speed, input checking and Animtions
    public static float speed = 200f;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;

    private Animator animator;

    Rigidbody rb;

    private float inputHorizontal;
    private float inputVertical;

    public float rotationSpeed;

    private void Start()
    {

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        //Find the correct inputs
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);

        //Moves character with inputs
        Vector3 movementDirection1 = new Vector3(inputHorizontal, 0, inputVertical);
        movementDirection1.Normalize();


        if (movementDirection1 != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection1, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        rb.velocity = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);

        // Idle and Walking Animations
        if (movementDirection1 == Vector3.zero)
        {
            // Idle Animation
            animator.SetFloat("Speed", 0);
        }
        else
        {
            animator.SetFloat("Speed", 1);
        }

        // Slap Animation
        if (Input.GetButton("Fire1Xbox"))
        {
            animator.Play("Sumo_Slap");
        }
    }
}
