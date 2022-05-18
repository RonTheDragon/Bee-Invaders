using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float speed;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        //get the screen size and bound
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime);
        //check if it's in the screen bounds*2
        if(transform.position.y< -screenBounds.y*2)
        {
            Destroy(this.gameObject);
        }
    }

}
