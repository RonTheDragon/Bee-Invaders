using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    public float HP = 3;

    public abstract void TakeDmg(float damage);
}
