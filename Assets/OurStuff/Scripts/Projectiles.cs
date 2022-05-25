using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    
    public float speed = 10f;
    public float dmg = 10;
    public Rigidbody2D rb;
    protected Vector2 screenbounds;
    [SerializeField] string attackable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void OnTriggerEnter2D(Collider2D coll)
    {
        //if it hits enemy, enemy takes dmg and destroy the bullet
        Health hp= coll.GetComponent<Health>();
        if (coll.CompareTag(attackable))
        {
            hp?.TakeDmg(dmg);
            Destroy(this.gameObject);
        }
    }
}
