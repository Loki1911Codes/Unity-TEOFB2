using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private float timer = 0f;

    public float speed = 5f;
    public playerStatsManager pSM;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        pSM = GameObject.FindGameObjectWithTag("Pstats").GetComponent<playerStatsManager>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        colliderFire();
        timer += Time.deltaTime;       
            
        
    }
    //only lets projectile stay around for x time
    private void active()
    {
        if (timer >= 5)
        {
            Destroy(gameObject);
        }
    }

    public void colliderFire()
    {
    
        // Calculate the direction from the object to the player
        Vector2 direction = playerTransform.transform.position - transform.position;

        // Normalize the direction vector to get a unit vector
        direction.Normalize();

        // Move the object towards the player using MoveTowards
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.transform.position, speed * Time.deltaTime);
        timer = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            pSM.changeHealth(10);
            Destroy(gameObject);
        }
    }
}
