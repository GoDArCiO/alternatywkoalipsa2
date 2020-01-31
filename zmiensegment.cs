using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmiensegment : MonoBehaviour
{
    public GameObject[] z;
    public GameObject na;
    public int blok = 0;
    float x = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") && blok == 0)
        {
            for (int i = 0; i < z.Length; i++)
            {
                z[i].SetActive(false);
            }
            na.SetActive(true);
            blok = 1;
        }
    }
    void Update()
    {
        if (x < 1)
        {
            x += Time.deltaTime;
        }
        else
        {
            blok = 0; x = 0;
        }
    }
}
