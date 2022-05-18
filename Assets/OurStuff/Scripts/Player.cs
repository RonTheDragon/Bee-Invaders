using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 0;
    public static float HP = 3;
    private Vector2 screenbounds;
    private Rigidbody2D rb;
    private Vector3 startpos;
    public Text text;
    public Text end;
    // Start is called before the first frame update
    void Start()
    {
        //present HP
        text.text = "HP: " + HP;
        //Start position
        startpos = transform.position;
        //get the screen bounds
        screenbounds= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //check if it's in bounds, if not put to the other corner of the screen
        if (transform.position.x > -screenbounds.x && transform.position.x < screenbounds.x)
        {
            float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.position += new Vector3(move, 0);
        }
        else if(transform.position.x >= screenbounds.x)
        {
            transform.position = new Vector3(-screenbounds.x * 0.9f, transform.position.y);
        }
        else if (transform.position.x <= -screenbounds.x)
        {
            transform.position = new Vector3(screenbounds.x*0.9f, transform.position.y);
        }

    }

    //destroy obj and create new in the start pos
    //if i get hit few times, game over
    public void TakeDmg()
    {
        HP--;
        text.text = "" + HP;
        if (HP>0)
        {
            ReSpawn();
            Destroy(this.gameObject);
        }
        else
        {
            HP = 0;
            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
            end.text="Game Over";
        }
    }

    public void ReSpawn()
    {
        Instantiate(this.gameObject, startpos, this.transform.rotation);
    }
}
