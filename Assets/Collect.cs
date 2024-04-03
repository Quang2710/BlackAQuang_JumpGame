using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    int coins = 0;
    public TextMeshProUGUI countText;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("coin"))
        {
           
            coins = coins + 1;
            countText.text = "Count:" + coins.ToString();

        }
    }
  

}
