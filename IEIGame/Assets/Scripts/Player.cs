using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static event Action OnPlayerDeath;

    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private int damage;

    [SerializeField] private HealthBar healthBar;

    void Start()
    {

        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);

        StartCoroutine(DrainHealth());
        
    }

    void Update()
    {



    }

    private IEnumerator DrainHealth()
    {

        while (currentHealth > 0)
        {

            yield return new WaitForSeconds(1);

            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);

        }

        if (currentHealth <= 0)
        {

            Death();

        }

    }

    public void Heal(int amount)
    {

        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);

        healthBar.SetHealth(currentHealth);

    }

    private void Death()
    {

        OnPlayerDeath?.Invoke();

    }

}
