using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sciekinamiasto : MonoBehaviour
{
    public GameObject aktywnesciekitlo;
    public GameObject miasto1;
    public GameObject miasto2;
    public int blok = 0;
    // Start is called before the first frame update
    public void zblokuj()
    {
        blok = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (aktywnesciekitlo.activeInHierarchy&&Time.timeScale==0.0f&&blok==0)
        {
            aktywnesciekitlo.SetActive(false);
            miasto1.SetActive(true);
            miasto2.SetActive(true);
        }
    }
}
