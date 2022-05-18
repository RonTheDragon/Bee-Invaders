using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float dmg = 10;
    public Rigidbody2D rb;
    private Vector2 screenbounds;
    // Start is called before the first frame update
    void Start()
    {
        //bullet goes up
        rb.velocity = transform.up * speed;
        //screen bounds
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void Update()
    {
        //if bullet reaches screen bound
        if (transform.position.y > screenbounds.y)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //if it hits enemy, enemy takes dmg and destroy the bullet
        Enemy enemy = coll.GetComponent<Enemy>();
        if (coll.CompareTag("Enemy"))
        {
            enemy.TakeDmg(dmg);
            Destroy(this.gameObject);
        }
    }
}
