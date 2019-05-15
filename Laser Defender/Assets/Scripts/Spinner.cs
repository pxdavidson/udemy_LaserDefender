using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Declare variables
    [SerializeField] float rotationRate = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationRate / Time.deltaTime);
    }
}
