using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed;
    private Vector2 screenBounds;

    void Start()
    {
        //get the screen size and bound
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update()
    {
        transform.position += Vector3.forward * speed;    
        Destroy(this.gameObject,3);
    }
}
