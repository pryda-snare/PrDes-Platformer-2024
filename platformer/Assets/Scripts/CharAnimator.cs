using UnityEngine;
using System;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))] // go to way to make sure it has a rigidbody
public class CharAnimator : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer _renderer;
    public MovementController MC;
    public string idle = "playerIdle";
    public string run = "playRun";
    public string fall = "playerFall";
    public string jump = "playerJump";

    private Rigidbody2D rb;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       animator = gameObject.GetComponent<Animator>();
       animator.Play(idle);
    }

    // Update is called once per frame
    void Update()
    {
        if (MC.horizontalInput != 0) _renderer.flipX = MC.horizontalInput < 0;
        if (rb.linearVelocityY > 0)
        {
            animator.CrossFade(jump, 0, 0);
        }
        else if (rb.linearVelocityY < 0)
        {
            animator.Play(fall);
        }
        else if(rb.linearVelocityX != 0)
        {
            animator.CrossFade(run, 0, 0);
        }
        else
        {
            animator.Play(idle);
        }
    }

 
}



