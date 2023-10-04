using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public Enemy1 em1;
    public playerStatsManager pSM;
    public int damageAmount = 10; // Configurable damage amount
    public float damagePerSecond = 5f; // Configurable damage per second

    private bool isPlayerInRange = false;
    private float damageTimer = 0f;

    private void Update()
    {
        if (isPlayerInRange)
        {
            em1.state = "Attacking Target";
            
            damageTimer += Time.deltaTime;

            if (damageTimer >= 1f / damagePerSecond)
            {
                ApplyDamage();
                damageTimer = 0f;
            }
        }
        else
        {
        em1.state = "Wandering";
        }
    }

    private void ApplyDamage()
    {
        // Check if the player is colliding with the collision box
        // You can modify this condition based on your specific setup
        if (isPlayerInRange)
        {
            // Apply damage to the player
            // You can replace this with your own logic or method
            pSM.changeHealth(5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isPlayerInRange = false;
            damageTimer = 0f; // Reset the damage timer when the player exits the collision box
        }
    }
    private void Start()
    {
        pSM = GameObject.FindGameObjectWithTag("Pstats").GetComponent<playerStatsManager>();
        em1 = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy1>();

    }
}
