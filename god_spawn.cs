using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class god_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform gdzie;
    public Object co;
    public void Pupa()
    {
        Instantiate(co);
        blokada = 0;
    }
    public int blokada = 0;
    // Update is called once per frame
    void Update()
    {
     if (blokada == 0)
        {
            Invoke("Pupa", 1);
            blokada = 1;
        }   
    }

}
