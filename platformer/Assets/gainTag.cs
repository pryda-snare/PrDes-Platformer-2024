using UnityEngine;

public class gainTag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sdfsdf");
        collision.gameObject.tag = "Player";
    }
}
