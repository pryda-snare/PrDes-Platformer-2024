using UnityEngine;
using System;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
public class CharAnimator : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer _renderer;
    public MovementController MC;
    public string idle = "playerIdle";
    public string run = "playerRun";
    public string fall = "playerFall";
    public string jump = "playerJump";

    private Rigidbody2D rb;

    public enum PlayerState { Idle, Run, Jump, Fall}

    private PlayerState currentState;
   


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       animator = gameObject.GetComponent<Animator>();
       animator.Play(idle);
       currentState = PlayerState.Idle;
    }

    void Update()
    {
        if (MC.horizontalInput != 0) _renderer.flipX = MC.horizontalInput < 0;

        PlayerState newState = GetState();

        if (newState != currentState)
        {
            currentState = newState;
            PlayAnimation(currentState);
        }
    }

    private PlayerState GetState()
    {
        if (rb.linearVelocityY > 0)
        {
            return PlayerState.Jump;
        }
        else if (rb.linearVelocityY < 0)
        {
            return PlayerState.Fall;
        }
        else if (rb.linearVelocityX != 0)
        {
            return PlayerState.Run;
        }
        else
        {
            return PlayerState.Idle;
        }
    }

    private void PlayAnimation(PlayerState state)
    {
        switch (state)
        {
            case PlayerState.Idle:
                animator.Play(idle);
                break;
            case PlayerState.Run:
                animator.Play(run);
                break;
            case PlayerState.Jump:
                animator.Play(jump);
                break;
            case PlayerState.Fall:
                animator.Play(fall);
                break;
        }

    }


}



