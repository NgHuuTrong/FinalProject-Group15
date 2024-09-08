using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    public int currentHealth, maxHealth;

    public float invicibleLength = 2f;

    private float invincCounter;
    public Sprite[] healthBarImages;
    public int hurtSFX;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if(invincCounter > 0)
        {
            invincCounter -= Time.deltaTime;

            for (int i = 0; i < PlayerController.instance.playerPieces.Length; i++)
            {
                if(Mathf.Floor(invincCounter * 5f) % 2 == 0)
                {
                    PlayerController.instance.playerPieces[i].SetActive(true);
                }
                else
                {
                    PlayerController.instance.playerPieces[i].SetActive(false);
                }

                if(invincCounter <= 0)
                {
                    PlayerController.instance.playerPieces[i].SetActive(true);
                }
            }
        }
    }

    public void Hurt()
    {
        if (invincCounter <= 0)
        {
            currentHealth--;
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                GameManager.instance.Respawn();
            }
            else
            {
                PlayerController.instance.knockback();
                invincCounter = invicibleLength;

                
            }

            AudioManager.instance.PlaySFX(hurtSFX);
            UpdateUI();
        }

    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
         UIManager.instance.healthImage.enabled = true;
        UpdateUI();
    }

    public void AddHealth(int amountToHeal)
    {
        currentHealth += amountToHeal;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateUI();
    }

    public void UpdateUI() {
        UIManager.instance.healthText.text = currentHealth.ToString();

        UIManager.instance.healthImage.sprite = healthBarImages[currentHealth];
        if(currentHealth == 0) {
            UIManager.instance.healthImage.enabled = false;
        }
    }

    public void PlayerKilled() {
        currentHealth = 0;
        UpdateUI();
    }
}
