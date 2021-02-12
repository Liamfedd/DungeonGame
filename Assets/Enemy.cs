﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //play hurt animation (Delete slashes once animations get added in)
        //animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Die animation (Delete slashes once animations get added in)
        //animator.SetBool("IsDead", true);

        //Disable the enemy 
        GetComponent<Collider>().enabled = false;
        this.enabled = false;
    }

}
