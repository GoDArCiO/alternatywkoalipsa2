using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class przycisk : MonoBehaviour
{
    public GameObject player;

    public void clicked1()
    {
        player.GetComponent<hpbar>().menu(0, 1, 1);

    }
    public void clicked2()
    {
        player.GetComponent<hpbar>().menu(1, 2, 2);

    }
    public void clicked3()
    {
        player.GetComponent<hpbar>().menu(1, 3, 3);

    }
    public void clicked4()
    {
        player.GetComponent<hpbar>().menu(1, 4, 3);

    }

}
