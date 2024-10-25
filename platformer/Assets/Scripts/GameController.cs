using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject guard;
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
            enemy.GetComponent<EnemyController>().setTarget(player);
        }
        
        // assign the enemies array as the waypoints for the guard
        guard.GetComponent<GuardController>().waypoints = enemies;
    }

    private GameObject SpawnEnemyRandomPos()
    {
        float randY = Random.Range(-10.0f, 10.0f);
        float randX = Random.Range(-17.0f, 17.0f);
        
        return Instantiate(enemyPrefab, new Vector3(randX, randY, 0), Quaternion.identity);
    }
}
