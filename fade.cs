using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{

    public int i = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {


            i = 1;
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<hpbar>().TakeDamage(100);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(100);
        }else
        Destroy(other.gameObject);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
