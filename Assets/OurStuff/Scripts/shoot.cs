using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    Player player;
    // Update is called once per frame
    void Start()
    {
    }
    void Update()
    {
        //if press up or down
        if (Input.GetButtonDown("Vertical"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //create bullet
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
