using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollider : MonoBehaviour
{
    public enum EType { spike, enemy }; 
    public EType type; // Variable to set the type of collider (spike or enemy)
    private string level;

    void Start()
    {
        level = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (type)
        {
            case EType.spike:
                if (col.gameObject.name == "Player")
                {
                    SceneManager.LoadScene(level);
                }
                else
                {
                    Destroy(col.gameObject);
                }
                break;

            case EType.enemy:
                if (col.gameObject.CompareTag("Player") && gameObject.CompareTag("Enemy"))
                {
                    if (col.gameObject.name == "Player")
                    {
                        if (col.transform.position.y <= transform.position.y)
                        {
                            SceneManager.LoadScene(level);
                        }
                        else { Destroy(gameObject); } // Destroy the enemy if hit from above}
                    }
                    else { Destroy(col.gameObject); } // Destroy other objects colliding with the enemy
                }
                break;
        }
    }
}