using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPAnimation : MonoBehaviour
{
    public Slider healthSlider;
    public playerStatsManager pSM;

    public void Update()
    {
        healthSlider.value = pSM.playerHealth;
    }

    public void Start()
    {
        pSM = GameObject.FindGameObjectWithTag("Pstats").GetComponent<playerStatsManager>();
    }

}
