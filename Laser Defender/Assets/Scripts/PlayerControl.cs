using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Declare variables
    [SerializeField] GameObject playerLaser;
    [SerializeField] float projectileSpeed = 20f;
    [SerializeField] float fireDelay = 1;
    Coroutine firingCoroutine;

    [SerializeField] float playerSpeed = 10f;

    float xMin;
    float xMax;
    float yMin;
    float yMax;

    // Start is called before the first frame update
    void Start()
    {
        SetMovementLimit();
    }

    // Limit the player movement within the screen confines
    private void SetMovementLimit()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0.075f, 0, 0)).x;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(0.925f, 0, 0)).x;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0.05f, 0)).y;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 0.9f, 0)).y;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerShip();
        FirePlayerLaser();
    }

    // Moves the player ship
    private void MovePlayerShip()
    {
        // Calculate speed variable using Time.deltaTime to unbind it from framerate
        float playerSpeedUnbound;
        playerSpeedUnbound = playerSpeed * Time.deltaTime;

        // Establish input variable to apply to player position
        var deltaX = Input.GetAxis("Horizontal") * playerSpeedUnbound;
        var deltaY = Input.GetAxis("Vertical") * playerSpeedUnbound;

        // Calculate new position of object while clamping within screen space
        var newXPos = Mathf.Clamp((transform.position.x + deltaX), xMin, xMax);
        var newYPos = Mathf.Clamp((transform.position.y + deltaY), yMin, yMax);

        // Update gameObject position
        transform.position = new Vector2(newXPos, newYPos);
    }

    // Instantiates the playerLaser GameOject and adds velocity
    private void FirePlayerLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            firingCoroutine = StartCoroutine(FireContinuously());
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(firingCoroutine);
        }
        else
        {
            // Do nothing
        }
    }

    // Fires laser for as long as the button is held down
    IEnumerator FireContinuously()
    {
        while (true)
        {
            GameObject playerLaserInstance = Instantiate(playerLaser, transform.position, Quaternion.identity) as GameObject;
            playerLaserInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
            yield return new WaitForSeconds(fireDelay);
        }
    } 
}
