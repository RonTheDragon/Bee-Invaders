using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : Health
{
    public Text textHP;
    Player playa;
    float shield = 0;
    float maxshield =5;
    public override void TakeDmg(float dmg)
    {
        if (shield<=0)
        {
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
        if (Input.GetKeyDown(KeyCode.F)&& shield<=0)
        {
            ShieldActivate();
        }
    }
}
