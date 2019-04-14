using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    // Detect collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shred(collision);
    }


    // Destroys whatever gameObject hitsthe collider
    private void Shred(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
