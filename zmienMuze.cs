using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmienMuze : MonoBehaviour
{
    public string z;
    public string na;
    public int blok = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player")&&blok==0)
        {
            FindObjectOfType<AudioManager>().StopPlayingAll();
            FindObjectOfType<AudioManager>().Play(na);
            blok = 1;
        }
    }
    private void Update()
    {

            if (Time.timeScale==0.0f)
            {
                blok = 0;
            }
        

    }
}
