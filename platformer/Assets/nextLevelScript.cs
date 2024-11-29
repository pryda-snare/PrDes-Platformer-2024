using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("lesson2");
        }
    }

}