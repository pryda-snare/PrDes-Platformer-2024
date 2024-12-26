using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // go to way to make sure it has a rigidbody
public class CharAnimator : MonoBehaviour
{
    public Animator animator;
    public string idle = "playerIdle";
    public string run = "playerRun";
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
        if (rb.linearVelocityY > 0)
        {
            animator.Play(jump);
        }
        else if (rb.linearVelocityY < 0)
        {
            animator.Play(fall);
        }
        else if(rb.linearVelocityX == 0)
        {
            animator.Play(idle);
        }
        else
        {
            animator.Play(run);
        }
    }
}
