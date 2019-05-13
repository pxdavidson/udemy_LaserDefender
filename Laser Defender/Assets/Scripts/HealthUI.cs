using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    // Cache
    Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
    }

    // Sets the playerHealth var
    public void SetPlayerHealth(int currentHealth)
    {
        int playerHealth = FindObjectOfType<PlayerControl>().ReturnPlayerHealth();
        healthText.text = playerHealth.ToString();
    }
}
