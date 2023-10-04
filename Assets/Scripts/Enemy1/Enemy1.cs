using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Collision coll;

    public Detection detect;
    public Collision Projectile;
    private float timer;
    public float moveSpeed = 3f;
    public float projectileSpeed = 5;
    public GameObject projectile1;
    private Vector3 targetPosition; // Target position for movement
    public float healthPoints;
    public float defense;
    public Rigidbody2D rb;
    public string state;
    private float timer1 = 1;

    void Start()
    {
        state = "Wandering Target";
        timer = 0;
        GenerateRandomTargetPosition();
        timer1 = 0;
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        coll = GameObject.FindGameObjectWithTag("Projectile").GetComponent<Collision>();

    }

    void GenerateRandomTargetPosition()
    {
        float randomX = Random.Range(-5f, 5f); //can adjust range
        float randomY = Random.Range(-5f, 5f); //can adjust range
        targetPosition = new Vector3(randomX, randomY, 0f);
    } 

    public void ShootProjectile()
    {
        if (timer1 >= 3)
        {
            // Instantiate the projectile prefab
            GameObject projectile = Instantiate(projectile1, transform.position, Quaternion.identity);
            timer1 = 0;
            coll.colliderFire();
            
        }
    }


    void Update()
    {
        timer1 += Time.deltaTime;
    
        if (state != "Attacking Target")
        {
            timer += Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position , targetPosition) < 0.1f)
            {
                if (timer >= 3)//If it takes too long to reach target it will set new
                {
                    GenerateRandomTargetPosition();
                    timer = 0;
                }
            }
        }
        if (state == "Attacking Target")
        {
            ShootProjectile();
        }
    }
}
