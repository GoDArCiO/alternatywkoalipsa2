using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealDMG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<hpbar>().TakeDamage(100);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
