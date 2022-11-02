using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggplant : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        
         if(other.gameObject.tag == "Player")
        {
            HealthManager.instance.Heal(1);
            Destroy(gameObject);
        }
    }
}
