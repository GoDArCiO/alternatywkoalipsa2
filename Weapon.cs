using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public Slider ammoBar;
    public int ammo;
    public float offset;
    public int zuzycie;

    public GameObject projectile;
    //public GameObject shotEffect;
    public Transform shotPoint;
    //public Animator camAnim;

    private float timeBtwShots;
    public float startTimeBtwShots;
    public int kierunek = 0;
    private void Update()
    {
        ammoBar.value = ammo;
        if (Input.GetKey("d")&&kierunek==1)
        {
            kierunek = 0;
            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        if (Input.GetKey("a")&&kierunek==0)
        {
            kierunek = 1;
            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0&&ammo>zuzycie)
        {
            if (Input.GetMouseButton(0))
            {
                //Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                //camAnim.SetTrigger("shake");
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
                ammo -= zuzycie;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
    public void refil(int x)
    {
        //Instantiate(explosion, transform.position, Quaternion.identity);
        ammo +=x;
        if (ammo > 100) { ammo = 100; }
    }
    public void fil(int x)
    {
        //Instantiate(explosion, transform.position, Quaternion.identity);
        ammo = x;
    }
}