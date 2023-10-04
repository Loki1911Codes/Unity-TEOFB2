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

      }else{
         Debug.Log("Dead!");
         playerHealth = 0;
      
      }
   }
}
