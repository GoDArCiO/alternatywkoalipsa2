using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class supermon : MonoBehaviour
{
    public static int mamSuper=0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //nie ma gry podczas dialogu czyli stop time, a pozatym, dialog triggeruje sie raz na gre
        //nie ma strzelania podczas dialogu czyli weapon active=0

        if (other.gameObject.CompareTag("Player"))
        {
            mamSuper = 1;
        }

    }
}
