using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class missile : MonoBehaviour
{
    private Vector3 gdzie;
    public float health=1;
    public float mhealth=1;
    public GameObject deathEffect;
    public int diesound = 0;
    public GameObject ja;

    // Start is called before the first frame update
    void Start()
    {
        gdzie = transform.position;
        mhealth = 1;
        FindObjectOfType<AudioManager>().Play("missile");
        ja.GetComponent<AIDestinationSetter>().target = GameObject.FindWithTag("Player").transform;
    }
    //jak skoliduje z solidem to zdycha
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0.0f) { health = 0; }
        if (health <= 0)
        {
            FindObjectOfType<AudioManager>().Play("boom");
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            ja.SetActive(false);
            FindObjectOfType<AudioManager>().StopPlaying("missile");
        }
        
    }
    public void TakeDamage(int damage)
    {
        //Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            health = 0;
            other.GetComponent<hpbar>().TakeDamage(50);
        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("solid"))
        {
            health = 0;
        }
    }
}
