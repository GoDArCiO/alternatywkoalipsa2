using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{

    public GameObject fotka1;
    public GameObject dialogus;

    public GameObject deathEffect;
    public GameObject explosion;
    public GameObject jasam;

    public Slider bosBar;
    public int boshealth;
    public GameObject image;
    public int ilosc = 0;
    public int ochrona = 1;

    public GameObject dzwig11;
    public GameObject dzwig12;
    public GameObject dzwig13;
    public GameObject dzwig21;
    public GameObject dzwig22;
    public GameObject dzwig23;

    public GameObject dzwiggg;
    public GameObject dzwigg;
    public GameObject dzwig;

    public GameObject progresbar;
    public GameObject v;

    public int blokers = 0;
    public int bloker = 0;
    public int blokers2 = 0;

    // Update is called once per frame
    void Update()
    {
        if (boshealth < 51 && blokers2 == 0&& DialogueManager.zmiennaDialogowa == 5)
        {
                progresbar.SetActive(true);
                FindObjectOfType<AudioManager>().StopPlayingAll();
                FindObjectOfType<AudioManager>().Play("starwarsBOSS");
                dzwig.GetComponent<lever>().dzwigniaup();
                dzwigg.GetComponent<lever>().dzwigniaup();
                dzwiggg.GetComponent<lever>().dzwigniaup();
                
            blokers2 = 1;
        }
            if (boshealth < 1&&bloker==0)
        {
            v.SetActive(true);
            FindObjectOfType<AudioManager>().StopPlayingAll();
            FindObjectOfType<AudioManager>().Play("victory");
            jasam.SetActive(false);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            bloker = 1;
        }
            if (boshealth < 51&&blokers==0)
        {
            ochrona = 1;
            ilosc = 0;
            dzwig11.SetActive(false);
            dzwig12.SetActive(false);
            dzwig13.SetActive(false);
            dzwig21.SetActive(true);
            dzwig22.SetActive(true);
            dzwig23.SetActive(true);
            fotka1.SetActive(true);
            dialogus.GetComponent<DialogueTrigger>().TriggerDialogue();
            blokers = 1;
        }
        bosBar.value = boshealth;
        if (ilosc == 3)
        {
            ochrona = 0;
        }
        else
        {
            ochrona = 1;
        }
        if (ochrona == 1)
        {
            image.GetComponent<Image>().color = new Color32(11, 217, 241, 255);
        }
        if (ochrona == 0)
        {
            image.GetComponent<Image>().color = new Color32(241, 37, 11, 255);
        }
    }

    public void TakeDamage(int damage)
    {
        //Instantiate(explosion, transform.position, Quaternion.identity);

        if (ochrona == 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            if (boshealth < 51)
            {
                boshealth -= 10*damage;
            }
            else
            {
                boshealth -= damage;
            }

        }
        //if (health < 0) { health = 0; }
        //if (health > mhealth) { health = 0; }
        
    }
    public void reset()
    {
        ochrona = 1;
        ilosc = 0;
        blokers = 0;
        blokers2 = 0;
                boshealth = 100;
        progresbar.SetActive(false);
    }
    public void dzwigniaup()
    {
        ilosc++;
    }
    public void dzwigniadown()
    {
        ilosc--;
    }
}
