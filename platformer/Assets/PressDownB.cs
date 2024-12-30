using UnityEngine;

public class PressDownB : MonoBehaviour
{
    private Animator animator;
    public RuntimeAnimatorController buttonAC;

    private void Start()
    {
       
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        Animator animator = gameObject.GetComponent<Animator>();
        if (col.gameObject.CompareTag("Player") && animator.runtimeAnimatorController == buttonAC)
        {
            animator.Play("buttDown");
        }

    }
    void OnTriggerExit2D(Collider2D col)
    {
        Animator animator = gameObject.GetComponent<Animator>();
        if (col.gameObject.CompareTag("Player") && animator.runtimeAnimatorController == buttonAC)
        {
            animator.Play("buttIdle");
        }
    }
}
    