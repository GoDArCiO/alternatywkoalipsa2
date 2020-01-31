using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    int blok = 0;
    public GameObject pierwsza;
    public GameObject czwarta;
    public GameObject druga;
    void Update()
    {
        if (Time.timeScale == 0.0f)
        {
            czwarta.SetActive(true);
            pierwsza.SetActive(false);
            blok = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")&&blok==0)
        {
            czwarta.SetActive(false);
            pierwsza.SetActive(true);
            druga.GetComponent<boss>().dzwigniaup();
            blok = 1;
        }





    }
    public void dzwigniaup()
    {
        blok = 0;
    }
}
