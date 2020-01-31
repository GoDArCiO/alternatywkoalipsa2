using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupammo : MonoBehaviour
{
    public int numer;
    public GameObject go;
    public int x = 20;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("pammo");
            other.gameObject.GetComponentInChildren<Weapon>().refil(x);
            go.SetActive(false);
        }
    }

}
