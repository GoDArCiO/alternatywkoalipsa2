using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupWeap : MonoBehaviour
{
public int numer;
    public GameObject go;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("pweap");
            other.gameObject.GetComponent<WeapKontrol>().ser(numer);
            Destroy(go);
        }
    }
            // Update is called once per frame
            void Update()
    {
        
    }
}
