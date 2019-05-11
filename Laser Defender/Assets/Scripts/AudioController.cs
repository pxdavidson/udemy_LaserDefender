using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Declare variables
    [SerializeField] AudioClip enemyExplodeSFX;
    [SerializeField] [Range(0, 1)] float enemyExplodeVolume = 0.75f;
    [SerializeField] AudioClip enemyFireSFX;
    [SerializeField] [Range(0, 1)] float enemyFireVolume = 0.75f;
    [SerializeField] AudioClip playerExplodeSFX;
    [SerializeField] [Range(0, 1)] float playerExplodeVolume = 0.5f;
    [SerializeField] AudioClip playerFireSFX;
    [SerializeField] [Range(0, 1)] float playerFireVolume = 0.25f;

    // Plays Enemy Explode SFX
    public void PlayEnemyExplode()
    {
        AudioSource.PlayClipAtPoint(enemyExplodeSFX, transform.position, enemyExplodeVolume);
    }

    // Plays Enemy Fire SFX
    public void PlayEnemyFire()
    {
        AudioSource.PlayClipAtPoint(enemyFireSFX, transform.position, enemyFireVolume);
    }

    // Plays Player Explode SFX
    public void PlayPlayerExplode()
    {
        AudioSource.PlayClipAtPoint(playerExplodeSFX, transform.position, playerExplodeVolume);
    }

    // Plays Player Fire
    public void PlayPlayerFire()
    {
        AudioSource.PlayClipAtPoint(playerFireSFX, transform.position, playerFireVolume);
    }
}
