using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgChange : MonoBehaviour
{
    public GameObject pierwsza;
    public GameObject druga;
    public GameObject trzecia;
    public GameObject czwarta;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pierwsza.SetActive(true);
            druga.SetActive(true);
            trzecia.SetActive(false);
            czwarta.SetActive(false);
        }
    }
}
