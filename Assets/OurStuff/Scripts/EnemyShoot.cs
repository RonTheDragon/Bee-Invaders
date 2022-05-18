using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the
public class EnemyShoot : Projectiles
{
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
}
