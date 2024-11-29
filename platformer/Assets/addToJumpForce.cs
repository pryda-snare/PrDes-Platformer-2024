using UnityEngine;

public class addToJumpForce : MonoBehaviour
{
    public GameObject go1otherbutton;
    public GameObject go2Player;
    public bool check = false;

    public int number;
    private addJumpForceMethod getnumber;

    private jumpController jumpC;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    getnumber = go1otherbutton.GetComponent<addJumpForceMethod>();

        jumpC = go2Player.GetComponent<jumpController>();
    
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check == false)
        {
            number = getnumber.HowMuchToAdd;
            jumpC.jumpForce = number;
            check = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = false;
        }
    }



}
