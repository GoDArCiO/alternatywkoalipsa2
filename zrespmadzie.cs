using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zrespmadzie : MonoBehaviour
{
    public GameObject madzia;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            madzia.SetActive(true);

        }

    }
}
