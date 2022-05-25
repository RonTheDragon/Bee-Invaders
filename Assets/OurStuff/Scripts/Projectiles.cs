using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    
    public float speed = 1;
    public float dmg = 1;
    public Rigidbody rb;
    protected Vector2 screenbounds;
    [SerializeField] string attackable;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    protected void OnTriggerEnter(Collider coll)
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
