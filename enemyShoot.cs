using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public float offset;
    public int zuzycie;

    public GameObject projectile;
    //public GameObject shotEffect;
    public Transform shotPoint;
    //public Animator camAnim;

    private Transform player;
    private Vector2 target;

    private float timeBtwShots;
    public float startTimeBtwShots;
    public int kierunek = 0;
    public int odleglosc;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }
        private void Update()
    {

        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(target) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0 )
        {
            if (Vector2.Distance(transform.position,player.position) < odleglosc) {
                //Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                //camAnim.SetTrigger("shake");
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
                ;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
}
