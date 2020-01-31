using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zapelniajsieminute : MonoBehaviour
{
    public Slider progres;
    public float procenty;
    public GameObject hpbar;
    public Text cyferki;
    // Start is called before the first frame update
    public void reset()
    {
        procenty = 0;

    }

    // Update is called once per frame
    void Update()
    {
        cyferki.text = "" + (int)procenty;
        progres.value = procenty;
        procenty += Time.deltaTime;
        if (procenty > 59)
        {
            hpbar.GetComponent<hpbar>().TakeDamage(100);
        }
    }
}
