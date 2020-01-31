using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uicontrol : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public int wlacz = 0;
    // Update is called once per frame
    void Update()
    {

        if (wlacz == 1)
        {
            s1.SetActive(true);
            s2.SetActive(false);
            s3.SetActive(false);
            o1.SetActive(false);
            o2.SetActive(true);
            o3.SetActive(true);
        }
        if (wlacz == 2)
        {
            s1.SetActive(false);
            s2.SetActive(true);
            s3.SetActive(false);
            o1.SetActive(true);
            o2.SetActive(false);
            o3.SetActive(true);
        }
        if (wlacz == 3)
        {
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(true);
            o1.SetActive(true);
            o2.SetActive(true);
            o3.SetActive(false);
        }
    }
    public void ser(int i)
    {
        wlacz = i;
    }
}
