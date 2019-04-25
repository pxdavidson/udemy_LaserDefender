using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Declare varables
    [SerializeField] int damage = 10;

    // Returns the damage value
    public int GetDamage()
    {
        return damage;
    }

    // Destroys gameObject when called
    public void Hit()
    {
        Destroy(gameObject);
    }

}
