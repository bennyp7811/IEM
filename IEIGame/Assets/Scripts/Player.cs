using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{

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

    //void Update()
    //{



    //}

    private IEnumerator DrainHealth()
    {

        while (currentHealth > 0)
        {

            yield return new WaitForSeconds(1);

            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);

        }


    }


}
