using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileTurret : MonoBehaviour
{
    private Vector3 gdzie;
    public float health;
    public float mhealth;
    public GameObject deathEffect;
    public GameObject explosion;
    public Transform bar;
    public GameObject missile;
    public float timerek;
    int x=1;

    private void Start()
    {
        gdzie = transform.position;
        mhealth = 2;
        x = 1;
    }
    private void Update()
    {

        if (health <= 0)
        {
            x = 1;
            timerek = 5;
            FindObjectOfType<AudioManager>().Play("electricdie");
           Instantiate(deathEffect, transform.position, Quaternion.identity);
                health = 2;
                bar.localScale = new Vector3(2 / 2, 1f);
            gameObject.SetActive(false);//deaktiv 1, transfer if deactiv/activ patrol, health 1 , activ
        }
        if (timerek <= 0&&x==0)
        {
            Instantiate(missile, transform.position, Quaternion.identity);
            timerek = 5;
        }
        else if(x==0)
        {
            timerek -= Time.deltaTime;
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
    public void elo()
    {
        x = 0;
    }
}
