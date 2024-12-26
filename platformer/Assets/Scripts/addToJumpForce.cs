using UnityEngine;

public class addToJumpForce : MonoBehaviour
{

    //store the int of jump here and access it from the two other scripts, set their + value to 1 or zero
    public int number;
    private jumpController jumpC;
    public GameObject thePlayer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpC = thePlayer.GetComponent<jumpController>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        jumpC.jumpForce = number;
    }
}
