using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obracaj : MonoBehaviour
{
    float i=0;
    float x = 0;
    public GameObject strzal;
    public int start;
    // Start is called before the first frame update
    void Start()
    {
        x = start;
    }

    // Update is called once per frame
    void Update()
    {
        if (x > 5)
        {
            strzal.SetActive(false);
            if (i < 360)
            {
                transform.rotation = Quaternion.Euler(0, 0, i);
                i += (start+1)*50 * Time.deltaTime;
            }
            else
            {
                i = 0;
            }

        }
        else
        {
            strzal.SetActive(true);
        }
        if(x<10)
        {
            x += Time.deltaTime;
        }
        else
        {

            x = 0;
        }
    }
}
