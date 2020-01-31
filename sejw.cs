using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sejw : MonoBehaviour
{
    public int save = 0;
    public int blok = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") && blok == 0)
        {
            other.gameObject.GetComponent<hpbar>().ser(save);
            blok = 1;
        }
    }
}
