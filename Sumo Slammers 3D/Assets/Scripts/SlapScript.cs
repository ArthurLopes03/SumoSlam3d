using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapScript : MonoBehaviour
{
    //I changed it up a bit, this script will only activate the slap animation once a certain button is pressed.
    public bool isSlapping;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Slap();
        }
    }

    public void Slap()
    {
        if(!isSlapping) 
            animator.SetTrigger("SlapTrigger");
    }
}
