using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject bullet,explosion;
    public float xSpeed;
    public int score;
    public float ySpeed;
    public bool canShoot;
    public float fireRate;
    public float health;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        if (!canShoot) return;
        fireRate = fireRate + (Random.Range(fireRate / -2, fireRate / 2));
        InvokeRepeating("Shoot", fireRate, fireRate);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(xSpeed, ySpeed * -1);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Spaceship>().Damage();
            Die();
        }
    }
    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + score);
        Destroy(gameObject);
    }
    public void Damage()
    {
        health--;
        if (health == 0)
        {
            Die();
        }
    }
    void Shoot()
    {
        GameObject temp = (GameObject) Instantiate(bullet,transform.position,Quaternion.identity);
        temp.GetComponent<Bullet>().changeDirection();
    }
}
