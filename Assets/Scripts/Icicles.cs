using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icicles : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPos;
    private void OnTriggerEnter(Collider other) {
        
         if(other.gameObject.tag == "Player")
        {
            HealthManager.instance.Damage(2);
            other.transform.position = spawnPos.position;
            Destroy(gameObject);
        }
    }
}
