using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    // Declare variables
    int playerHealth = 200;


    // Cache
    Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealth.ToString();
    }

    // Sets the playerHealth var
    public void SetPlayerHealth(int currentHealth)
    {
        playerHealth = currentHealth;
    }
}
