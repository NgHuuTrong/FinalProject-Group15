using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healAmount;
    public bool isFullMeal;
    public GameObject pickupEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);

            if(isFullMeal)
            {
                HealthManager.instance.resetHealth();
            }
            else
            {
                HealthManager.instance.AddHealth(healAmount);
            }
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }
    }
}



