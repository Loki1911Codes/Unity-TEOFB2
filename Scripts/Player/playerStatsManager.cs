using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class playerStatsManager : MonoBehaviour
{
   public int playerHealth = 100;
   public Text playerHealthPoints;

   public void changeHealth(int hpToLose)
   {  
      if (playerHealth > hpToLose)
      {
      playerHealth = playerHealth - hpToLose;
      playerHealthPoints.text = playerHealth.ToString();
      }else{
         Debug.Log("Dead!");
         playerHealth = 0;
      playerHealthPoints.text = playerHealth.ToString();
      }
   }
}
