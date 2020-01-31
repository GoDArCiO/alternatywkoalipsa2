using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 gdzie;
    public float health;
    public float mhealth;
    public GameObject deathEffect;
    public GameObject explosion;
    public Transform bar;
    public int diesound=0;
    public int mobtype = 0;

    private void Start()
    {
        gdzie = transform.position;
        if (mobtype == 0) { mhealth = 10; }
        if (mobtype == 1) { mhealth = 5; }
        if (mobtype == 2) { mhealth = 3; }
    }
        private void Update()
    {

        if (health <= 0)
        {
            if (diesound == 0)
            {
                FindObjectOfType<AudioManager>().Play("die");
            }
            if (diesound == 1)
            {
                FindObjectOfType<AudioManager>().Play("electricdie");
            }
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            if (mobtype == 0)
            {
                health = 10;
                bar.localScale = new Vector3(10 / 10, 1f);
            }
            if (mobtype == 1)
            {//transfer
                transform.position = gdzie;
                health = 5;
                bar.localScale = new Vector3(5 / 5, 1f);
            }
            if (mobtype == 2)
            {//transfer+patroliren
                transform.position = gdzie;
                health = 3;
                bar.localScale = new Vector3(3 / 3, 1f);
                //GetComponent<AIDestinationSetter>().enabled = false; przeniesione do startu patroliren
                GetComponent<patroliren>().enabled = true;
            }

            gameObject.SetActive(false);//deaktiv 1, transfer if deactiv/activ patrol, health 1 , activ

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
                other.GetComponent<hpbar>().TakeDamage(100);
        }
    }

public void TakeDamage(int damage)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
        if (health < 0) { health = 0; }
        if (health > mhealth) { health = 0; }
        bar.localScale = new Vector3(health / mhealth, 1f);
    }








}