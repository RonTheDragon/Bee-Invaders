using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float speed = 10f;
    public float dmg = 20;
    public Rigidbody2D rb;
    private Vector2 screenbounds;
    private EnemyManager counter;
    // Start is called before the first frame update
    void Start()
    {
        //laser shoots down
        rb.velocity = Vector2.down * speed;
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void Update()
    {
        //laser bounds? if no he gets destroy;
        if (transform.position.y < -screenbounds.y*2)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //if he hit a player, takes life and get destroy
        Player player = coll.GetComponent<Player>();
        if (coll.CompareTag("Player"))
        {
            player.TakeDmg();
            Destroy(this.gameObject);
        }
    }
}
