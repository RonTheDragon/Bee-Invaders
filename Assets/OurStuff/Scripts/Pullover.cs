using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pullover : MonoBehaviour
{
    private Vector2 screenbounds;
    private Vector3 startpos;
    
    public float speed = -20;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed*Time.deltaTime);
        if (transform.position.y<screenbounds.y*10)
        {
            transform.position = new Vector3(0, transform.position.y*10);
        }
    }
}
