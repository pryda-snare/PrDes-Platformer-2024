using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score;
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
            enemy.GetComponent<EnemyController>().target = player;
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

    public void AddScore()
    {
        //Update score value first then append it to the UI string
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
