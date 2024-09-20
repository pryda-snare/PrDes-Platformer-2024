using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaseController : EnemyClass
{
    public ChaseController(int hp, int damage, int speed, EnemyType type, Image sprite)
    {
        this.hp = hp;
        this.damage = damage;
        this.speed = speed;
        this.type = type;
        this.sprite = sprite;
    }

    GameObject m_target;

    void Start()
    {
        m_target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        ChaseTarget();
    }

    void ChaseTarget()
    {
        Vector3 dest = m_target.transform.position;
        Vector3 pos = transform.position;
        float distance = 2 * Time.deltaTime;

        if (pos.x > dest.x)
        {
            pos.x -= distance;
        }
        else
        {
            pos.x += distance;
        }

        transform.position = pos;        
    }
}
