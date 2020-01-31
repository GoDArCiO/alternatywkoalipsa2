using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dajznak : MonoBehaviour
{
    public GameObject druga;
    public int znak = 0;
    int blok = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && blok == 0)
        {

            druga.SetActive(true);
            if (znak == 0)
            {
                druga.GetComponent<strielaj>().elo();
            }

            if (znak == 1)
            {
                druga.GetComponent<missileTurret>().elo();
            }
            blok = 1;
        }
    



    }
void Update()
{
    if (Time.timeScale == 0.0f) { blok = 0; }
}
}
