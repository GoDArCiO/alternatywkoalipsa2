using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otworzmenu : MonoBehaviour
{
    public GameObject ja;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            ja.SetActive(true);
        }
        else
        {
            ja.SetActive(false);
        }
    }
}
