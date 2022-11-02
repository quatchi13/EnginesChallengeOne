using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    public static HealthManager instance;
    // Start is called before the first frame update

    [SerializeField]
    private int health = 10;

    [SerializeField]
    private GameObject player;
    private void Awake() {
        if(!instance)
        {
           instance = this;
        }
    }

    private void Update() {
        if(health <= 0)
        {
            Destroy(player);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
    }

    public void Heal(int heal)
    {
        health += heal;
    }



}
