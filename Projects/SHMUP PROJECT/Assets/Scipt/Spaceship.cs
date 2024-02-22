using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject a, b;
    public GameObject bullet;
    public float speed;
    int health = 3;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        a = transform.Find("a").gameObject;
        b = transform.Find("b").gameObject;
    }

    void Start()
{
    
    PlayerPrefs.DeleteKey("Score");
    PlayerPrefs.SetInt("Health", health);
}



    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
        rb.AddForce(new Vector2 (0, Input.GetAxis("Vertical") * speed));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Damage()
    {
        health--;
        PlayerPrefs.SetInt("Health", health);
        if (health == 0)
        {
            
            Destroy(gameObject);
        }
    }
    void Shoot()
    {
        Instantiate(bullet,a.transform.position, Quaternion.identity);
        Instantiate(bullet,b.transform.position, Quaternion.identity);
    }
}
