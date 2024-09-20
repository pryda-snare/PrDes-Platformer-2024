using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyClass : MonoBehaviour
{
    public enum EnemyType
    {
        chase,
        guard,
        jump
    }

    public int hp, damage, speed;
    public Image sprite;
    public EnemyType type;
    
    public EnemyClass()
    {
        this.hp = 5;
        this.damage = 5;
        this.speed = 5;
        this.type = EnemyType.chase;
        this.sprite = null;
    }

    public EnemyClass(int hp, int damage, int speed, EnemyType type, Image sprite)
    {
        this.hp = hp;
        this.damage = damage;
        this.speed = speed;
        this.type = type;
        this.sprite = sprite;
    }


    public void setHP(int hp)
    {
        this.hp = hp;
    }
    public float getHP()
    {
        return hp;
    }

    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public float getDamage()
    {
        return damage;
    }
    
    public void setSpeed(int speed)
    {
        this.speed = speed;
    }
    public float getSpeed()
    {
        return speed;
    }

    public void setType(EnemyType type)
    {
        this.type = type;
    }
    public EnemyType getType()
    {
        return type;
    }

    public void setSprite(Image sprite)
    {
        this.sprite = sprite;
    }
    public Image getSprite()
    {
        return sprite;
    }
}