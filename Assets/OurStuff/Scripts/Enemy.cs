using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    public float direct = 1;
    private Vector2 screenbounds;
    public float Timer;
    public Vector2 FireCooldown;
    //public float Hp = 20;
    // Start is called before the first frame update
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    //check if enemy is in screen bound;
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            Timer = Random.Range(FireCooldown.x, FireCooldown.y);
            //Shoot();
        }
        transform.position += Vector3.right * speed * Time.deltaTime * direct;
        if (direct > 0 && transform.position.x>= screenbounds.x)
        {
            direct *= -1;
        }
        else if (direct < 0 && transform.position.x<= -screenbounds.x)
        {
            direct *= -1;
        }


    }


    public void SpawnAs()
    {
        
    }

}
