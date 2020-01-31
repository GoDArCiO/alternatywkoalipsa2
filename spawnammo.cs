using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnammo : MonoBehaviour
{
    public GameObject ammo;
    public GameObject ammo2;
    float i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 20)
        {
            i +=  Time.deltaTime;
        }
        else
        {
            ammo.SetActive(true);
            ammo2.SetActive(true);
            i = 0;
        }
    }
}
