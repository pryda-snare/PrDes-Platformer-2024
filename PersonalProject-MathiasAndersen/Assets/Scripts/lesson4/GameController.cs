using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemies;
    
    public int enemiesCount = 5;

    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //init enemies array
        enemies = new GameObject[enemiesCount];
        
        // spawning enemies
        for (int i = 0; i < enemiesCount; i++)
        {
            enemies[i] = SpawnEnemyRandomPos();
        }
        
        // iterate through the enemies and assign the player as the target
        foreach (GameObject enemy in enemies)
        {
            enemy.GetComponent<EnemyController>().target = player;
        }
        
    }

    private GameObject SpawnEnemyRandomPos()
    {
        float randY = Random.Range(-10.0f, 10.0f);
        float randX = Random.Range(-17.0f, 17.0f);
        
        return Instantiate(enemyPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            SpawnEnemyRandomPos();
        }
    }
}
