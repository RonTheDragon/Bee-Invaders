using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : Health
{
    public Text textHP;
    Player playa;
    [SerializeField] float shield = 0;
    float maxshield =5;

    public GameObject forcefield;
    public override void TakeDmg(float dmg)
    {
        if (shield<=0)
        {
            //forcefield.SetActive(false);
            HP -= dmg;
            textHP.text = "HP: " + HP;
            if (HP > 0)
            {
                playa.ReSpawn();
                Destroy(this.gameObject);
            }
            else
            {
                HP = 0;
                //this.gameObject.SetActive(false);
                Destroy(this.gameObject);
                playa.end.text = "Game Over";
            }
        }
      
    }
    void ShieldActivate()
    {
        shield = maxshield;
        forcefield.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        playa = GetComponent<Player>();
        textHP.text = "HP: " + HP;
    }

    // Update is called once per frame
    void Update()
    {
        if (shield>0)
        {
            shield -= Time.deltaTime;
        }
        if(shield<=0)
        {
            forcefield.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F)&& shield<=0)
        {
            ShieldActivate();
        }
    }
}
