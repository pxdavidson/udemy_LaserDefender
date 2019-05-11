using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Declare variables
    [Header ("Enemy")]
    [SerializeField] int health = 20;

    [Header ("Projectile")]
    [SerializeField] GameObject enemyLaser;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float fireRate = 0.5f;
    [SerializeField] float fireDelayMin = 0.3f;
    [SerializeField] float fireDelayMax = 2f;

    [Header("VFX")]
    [SerializeField] GameObject ExplosionVFX;

    // Cache
    AudioController audioController;


    // Start is called before the first frame update
    void Start()
    {
        audioController = FindObjectOfType<AudioController>();
        StartCoroutine(FireLaser());
    }

    // Fires the laser
    IEnumerator FireLaser()
    {
        while (true)
        {
            GameObject enemyLaserInstance = Instantiate(enemyLaser, transform.position, Quaternion.identity) as GameObject;
            audioController.PlayEnemyFire();
            enemyLaserInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projectileSpeed);
            yield return new WaitForSeconds(Random.Range(fireDelayMin, fireDelayMax));
        }
    }

    // Detects collision with a Rigidbody
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject projectile = collision.gameObject;
        ProcessDamage(projectile);
    }

    // Calculates and updates health
    private void ProcessDamage(GameObject projectile)
    {
        DamageDealer damageDealer = projectile.GetComponent<DamageDealer>();
        if (!damageDealer) { return; }
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
        GameObject VFXInstance = Instantiate(ExplosionVFX, transform.position, Quaternion.identity);
        audioController.PlayEnemyExplode();
        Destroy(VFXInstance, 1);
        Destroy(gameObject);
    }
}
