using UnityEngine;

public class jumpController : MonoBehaviour
{

    public float jumpForce = 5.0f;
    public bool grounded = false;
    public Rigidbody2D playerBody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            grounded = !grounded;
            playerBody.linearVelocity = new Vector2(playerBody.linearVelocity.x, jumpForce);
        }



    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }




}

