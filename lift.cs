using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
    public GameObject pierwsza;
    public GameObject czwarta;
    public GameObject druga;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            pierwsza.SetActive(true);
        druga.SetActive(true);

        czwarta.SetActive(false);

    }
}
