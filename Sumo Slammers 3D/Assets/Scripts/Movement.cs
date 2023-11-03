using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Speed, input checking and Animtions
    public static float speed = 225f;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;
    [SerializeField] private string slapName;

    public Animator animator;

    Rigidbody rb;

    private float inputHorizontal;
    private float inputVertical;

    public float rotationSpeed;

    private void Start()
    {
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


        rb.AddForce(-inputHorizontal * speed * Time.fixedDeltaTime, 0, -inputVertical * speed * Time.fixedDeltaTime);

        /*if (Input.GetAxis(inputHorizontal))
            rb.AddForce(new Vector3(-speed, 0, 0));
        else if (Input.GetAxis(inputHorizontal))
            rb.AddForce(new Vector3(speed, 0, 0));
        else if (Input.GetAxis(inputVertical))
            rb.AddForce(new Vector3(0, 0, speed));
        else if (Input.GetAxis(V))
            rb.AddForce(new Vector3(0, 0, -speed));*/


        // Idle and Walking Animations
        if (movementDirection1 == Vector3.zero)
        {
            // Idle Animation
            animator.SetFloat("Speed", 0);
            //animator2.SetFloat("Speed", 0);
        }
        else if(movementDirection1 != Vector3.zero)
        {
            animator.SetFloat("Speed", 1);
            //animator2.SetFloat("Speed", 1);
        }

        // Slap Animation
        if (Input.GetButton(slapName))
        {
            animator.Play("Sumo_Slap");
        }


        /*if (movementDirection1 == Vector3.zero)
        {
            // Idle Animation
            //animator1.SetFloat("Speed", 0);
            animator2.SetFloat("Speed", 0);
        }
        else
        {
            //animator1.SetFloat("Speed", 1);
            animator2.SetFloat("Speed", 1);
        } */

        // Slap Animation
    }
    
    /*
    void MovePlayer1()
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
    }
    */
}
