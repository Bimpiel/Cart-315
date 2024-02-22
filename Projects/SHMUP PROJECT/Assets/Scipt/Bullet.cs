using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    int dir = 1;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    public void changeDirection()
    {
        dir *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 10 * dir);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (dir == 1)
        {
            if (col.gameObject.tag == "Enemy")
            {
                col.gameObject.GetComponent<Enemy>().Damage();
                Destroy(gameObject);

            }
        }
        else
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<Spaceship>().Damage();
                Destroy(gameObject);

            }

        }




    }
}
