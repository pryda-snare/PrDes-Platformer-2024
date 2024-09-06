using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public Rigidbody2D playerBody;
    public GameObject Bullet;

    public float bulletSpeedModifier = 5.0f;
    public float delay = 1.0f;

    private float lastShot = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastShot += Time.deltaTime;
        Debug.Log(lastShot);

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 shotDir = mousePos - playerBody.transform.position;

        if (Input.GetKey(KeyCode.Mouse0) && lastShot > delay)
        {
            GameObject _bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            _bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shotDir.x * bulletSpeedModifier, shotDir.y * bulletSpeedModifier);
            lastShot = 0.0f;
        }
    }


}
