using UnityEngine;

public class gainTag : MonoBehaviour
{
    public RuntimeAnimatorController Player;      // Animator for "Player" tag

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.Play("buttDown");
        collision.gameObject.tag = "Player";
        Animator animator2 = collision.GetComponent<Animator>();
        animator2.runtimeAnimatorController = Player;

    }

    void OnTriggerExit2D(Collider2D col)
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator = GetComponent<Animator>();
        animator.Play("buttIdle");
    }


}
