using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Projectiles
{
    
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
}
