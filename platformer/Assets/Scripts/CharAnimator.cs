using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // go to way to make sure it has a rigidbody
public class CharAnimator : MonoBehaviour
{
    public Animator animator;
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
        Debug.Log($"VelocityX: {rb.linearVelocityX}, VelocityY: {rb.linearVelocityY}");
        if (rb.linearVelocityY > 0)
        {
            animator.CrossFade(jump, 0, 0);
            //animator.Play(jump);
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
