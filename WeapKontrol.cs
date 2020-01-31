using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapKontrol : MonoBehaviour
{
    public int aktywna=0;
    public GameObject pierwsza;
    public GameObject druga;
    public GameObject trzecia;
    public static int mam = 0;
    // Update is called once per frame
    public void ser(int elo)
    {
        mam = elo;
    }
    public void wylacz()
    {
        aktywna = 0;
    }
    void Update()
    {
        if (Input.GetKey("1") && aktywna != 1 &&mam>=1)
        {
            pierwsza.SetActive(true);
            trzecia.SetActive(false);
            druga.SetActive(false);
            aktywna = 1;
            GameObject.FindWithTag("uikontrol").GetComponent<uicontrol>().ser(1);
            FindObjectOfType<AudioManager>().Play("wybierzb");
        }
        if (Input.GetKey("2") && aktywna != 2 && mam >= 2)
        {
            pierwsza.SetActive(false);
            trzecia.SetActive(false);
            druga.SetActive(true);
            aktywna = 2;
            GameObject.FindWithTag("uikontrol").GetComponent<uicontrol>().ser(2);
            FindObjectOfType<AudioManager>().Play("szyb");
        }
        if (Input.GetKey("3") && aktywna != 3 && mam >= 3)
        {
            pierwsza.SetActive(false);
            trzecia.SetActive(true);
            druga.SetActive(false);
            aktywna = 3;
            GameObject.FindWithTag("uikontrol").GetComponent<uicontrol>().ser(3);
            FindObjectOfType<AudioManager>().Play("mocb");
        }
    }
}