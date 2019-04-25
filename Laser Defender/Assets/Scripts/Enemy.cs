using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Declare variables
    [SerializeField] int health = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ModifyHealth(collision);
        
    }

    // Calculates and updates health
    private void ModifyHealth(Collider2D collision)
    {
        DamageDealer damageDealer = collision.gameObject.GetComponent<DamageDealer>();
        health -= damageDealer.GetDamage();
        damageDealer.Hit();
        if (health <= 0)
        {
            Explode();
        }
        else
        {
            // Do nothing
        }
    }

    // Desroys gameObject
    private void Explode()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
