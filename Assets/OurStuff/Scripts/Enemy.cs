using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    public float direct = 1;
    private Vector2 screenbounds;
    public float Hp = 20;
    public GameObject enemylaser;
    public GameObject pointshoot;
    public bool tov = true;
    public AudioSource ex;
    public AudioSource shoot;
    // Start is called before the first frame update
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    //check if enemy is in screen bound;
    void Update()
    {

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

    public void TakeDmg(float dmg)
    {
        Hp -= dmg;
        if (Hp <= 0)
        {
            ex.Play();
            Destroy(this.gameObject);
            tov = false;
        }
        else
            tov = true;
    }

    public void SpawnAs()
    {
        //GameObject a = Instantiate(enemylaser) as GameObject;
        //a.transform.position = new Vector2(pointshoot.transform.position.x, pointshoot.transform.position.y);
        Instantiate(enemylaser, pointshoot.transform.position, enemylaser.transform.rotation);
        //shoot.Play();
        
    }

}
