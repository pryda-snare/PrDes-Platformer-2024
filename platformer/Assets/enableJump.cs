using UnityEngine;

public class enableJump : MonoBehaviour
{
    public  jumpController targetScript;
    private bool check = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && check==false)
        {
            targetScript.enabled = true;
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
