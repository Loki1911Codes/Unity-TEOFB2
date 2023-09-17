using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public playerStatsManager pSM;
    private float timer = 0;
    public float dps = 1;

    // Start is called before the first frame update
    void Start()
    {
        pSM = GameObject.FindGameObjectWithTag("Pstats").GetComponent<playerStatsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (timer < dps)
        {
            timer += Time.deltaTime;
        }else
        {
            if (collision.gameObject.layer == 3)
            {   
            pSM.changeHealth(5);
            timer = 0;
            }
        }
    }
}
