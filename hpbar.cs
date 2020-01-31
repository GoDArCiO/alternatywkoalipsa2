using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpbar : MonoBehaviour
{
    public GameObject tlorur;
    public GameObject tlo1;
    public GameObject tlo2;
    public GameObject tlo3;
    public GameObject tlobos;

    public int monster = 0;
    public float time=4;
    public Rigidbody2D rb2D;
    public GameObject kladka;
    private int bloking = 0;
    private int bloki = 0;
    public GameObject montok;

    public Slider hpBar;
    public float health;
    public GameObject Player;
    public Transform sejvik;
    public Transform sejvik1;
    public Transform sejvik2;
    public Transform sejvik3;
    public Transform sejvik4;
    public int Nsejw=0;
    public int blok;

    public GameObject[] gameObjects;
    public GameObject[] gameObjects1;
    public GameObject[] gameObjects2;
    public GameObject[] gameObjects3;
    public GameObject[] wszyscy;
    public GameObject[] wszyscy2;
    public GameObject[] pukawki;

    public GameObject boss;
    public GameObject progres;
    public int zmiana = 0;
    float blokdzwiek = 0;
    public GameObject bleed;
    public Text cyferki;

    public GameObject gameovscreen;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Enemy"))
        {
            health -= 10;

                if (zmiana == 0 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au0"); zmiana=1; blokdzwiek = 0.3f; }
                if (zmiana == 1 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au1"); zmiana=2; blokdzwiek = 0.3f; }
                if (zmiana == 2 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au2"); zmiana=3; blokdzwiek = 0.3f; }
                if (zmiana == 3 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au3"); zmiana=4; blokdzwiek = 0.3f; }
                if (zmiana == 4 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au4"); zmiana = 0; blokdzwiek = 0.3f; }
            Instantiate(bleed, transform.position, Quaternion.identity);

        }


    }

    void OnParticleCollision(GameObject other)
    {
            health -= 3;

            if (zmiana == 0 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au0"); zmiana=1; blokdzwiek = 0.3f; }
            if (zmiana == 1 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au1"); zmiana=2; blokdzwiek = 0.3f; }
            if (zmiana == 2 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au2"); zmiana=3; blokdzwiek = 0.3f; }
            if (zmiana == 3 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au3"); zmiana=4; blokdzwiek = 0.3f; }
            if (zmiana == 4 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au4"); zmiana = 0; blokdzwiek = 0.3f; }
        Instantiate(bleed, transform.position, Quaternion.identity);
    }
        public void TakeDamage(int damage)
    {
        //Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;

                if (zmiana == 0 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au0"); zmiana=1; blokdzwiek = 0.3f; }
                if (zmiana == 1 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au1"); zmiana=2; blokdzwiek = 0.3f; }
                if (zmiana == 2 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au2"); zmiana=3; blokdzwiek = 0.3f; }
                if (zmiana == 3 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au3"); zmiana=4; blokdzwiek = 0.3f; }
                if (zmiana == 4 && blokdzwiek <= 0) { FindObjectOfType<AudioManager>().Play("au4"); zmiana = 0; blokdzwiek = 0.3f; }
        Instantiate(bleed, transform.position, Quaternion.identity);
    }
    public void ser(int s)
    {
        Nsejw = s;
    }
    // Update is called once per frame
    void Update()
    {
        cyferki.text = "" + (int)health;
        if (health > 100) { health -= Time.deltaTime; }

        if (blokdzwiek > 0)
        {
            blokdzwiek -= Time.deltaTime;
        }
        if (!(time < 4))
        {
            FindObjectOfType<AudioManager>().StopPlaying("picie");
            bloking = 0;
            montok.SetActive(false);
        }else
        {
            montok.SetActive(true);
        }
        if (!Input.GetKey("m"))
        {
            time = 4;
        }
        if (Input.GetKey("m") && monster == 1 && health < 100)
        {

            if (bloking == 0)
            {
                FindObjectOfType<AudioManager>().Play("picie");
                bloking = 1;
            }
            if (Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w"))
            {
                if (bloking == 1)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("picie");
                    bloking = 0;
                }
                time = 4;
            }
            else
            {
                time -= Time.deltaTime;
            }
            if (time < 0)
            {
                if (bloking == 1)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("picie");
                    bloking = 0;
                }
                health += 50;
                if (supermon.mamSuper == 0)
                {
                    if (health > 100) { health = 100; }
                }
                else
                {
                    if (health > 125) { health = 125; }
                }
                time = 5;
            }
        }
        else if (Input.GetKey("m") && supermon.mamSuper == 1)
        {
            if (bloking == 0)
            {
                FindObjectOfType<AudioManager>().Play("picie");
                bloking = 1;
            }
            if (Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w"))
            {
                if (bloking == 1)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("picie");
                    bloking = 0;
                }
                time = 4;
            }
            else
            {
                time -= Time.deltaTime;
            }
            if (time < 0)
            {
                if (bloking == 1)
                {
                    FindObjectOfType<AudioManager>().StopPlaying("picie");
                    bloking = 0;
                }
                health += 50;
                if (supermon.mamSuper == 0)
                {
                    if (health > 100) { health = 100; }
                }
                else
                {
                    if (health > 125) { health = 125; }
                }
                time = 5;
            }
        }
            hpBar.value = health;
        if (health <= 0)
        {//tp to nearest checkpoint

            gameovscreen.SetActive(true);
            rb2D.constraints = RigidbodyConstraints2D.FreezeAll;
            kladka.GetComponent<wroc>().Wracanko();
            //zabij wszystkich 
            if (blok == 0)
            {
                FindObjectOfType<AudioManager>().StopPlayingAll();
                FindObjectOfType<AudioManager>().Play("gameover");

                for (int i = 0; i < wszyscy.Length; i++)
                {
                    wszyscy[i].SetActive(true);
                    wszyscy[i].GetComponent<Enemy>().TakeDamage(10);
                }
                for (int i = 0; i < wszyscy2.Length; i++)
                {
                    wszyscy2[i].SetActive(true);
                    wszyscy2[i].GetComponent<missileTurret>().TakeDamage(10);
                }
                for (int i = 0; i < pukawki.Length; i++)
                {
                    pukawki[i].SetActive(true);
                    pukawki[i].GetComponent<Weapon>().fil(30);
                    pukawki[i].SetActive(false);
                }
                pukawki[0].SetActive(true);
                blok = 1;
            }
            Time.timeScale = 0.0f;
            if (Input.GetKeyDown("r"))
            {
                Time.timeScale = 1.0f;
                FindObjectOfType<AudioManager>().StopPlaying("gameover");
                gameovscreen.SetActive(false);
                if (Nsejw == 0)
                {
                    Player.transform.position = sejvik.transform.position;

                    for (int i = 0; i < gameObjects.Length; i++)
                    {
                        //gameObjects[i].SetActive(false);
                        //gameObjects[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects1.Length; i++)
                    {
                        //gameObjects1[i].SetActive(false);
                        //gameObjects1[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects1[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects2.Length; i++)
                    {
                        //gameObjects2[i].SetActive(false);
                        //gameObjects2[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects2[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects3.Length; i++)
                    {
                        //gameObjects3[i].SetActive(false);
                        //gameObjects3[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects3[i].SetActive(true);
                    }


                }//spawn and set health
                if (Nsejw == 1)
                {
                    Player.transform.position = sejvik1.transform.position;

                    for (int i = 0; i < gameObjects1.Length; i++)
                    {
                        //gameObjects1[i].SetActive(false);
                        //gameObjects1[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects1[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects2.Length; i++)
                    {
                        //gameObjects2[i].SetActive(false);
                        //gameObjects2[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects2[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects3.Length; i++)
                    {
                        //gameObjects3[i].SetActive(false);
                        //gameObjects3[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects3[i].SetActive(true);
                    }
                    FindObjectOfType<AudioManager>().StopPlayingAll();
                    FindObjectOfType<AudioManager>().Play("divinity happy");
                    tlo1.SetActive(true);
                    tlo2.SetActive(false);
                    tlo3.SetActive(false);
                    tlorur.SetActive(false);
                    tlobos.SetActive(false);

                }
                if (Nsejw == 2)
                {
                    Player.transform.position = sejvik2.transform.position;

                    for (int i = 0; i < gameObjects2.Length; i++)
                    {
                        //gameObjects2[i].SetActive(false);
                        //gameObjects2[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects2[i].SetActive(true);
                    }
                    for (int i = 0; i < gameObjects3.Length; i++)
                    {
                        //gameObjects3[i].SetActive(false);
                        //gameObjects3[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects3[i].SetActive(true);
                    }
                    FindObjectOfType<AudioManager>().StopPlayingAll();
                    FindObjectOfType<AudioManager>().Play("Trine");
                    tlo1.SetActive(true);
                    tlo2.SetActive(false);
                    tlo3.SetActive(false);
                    tlorur.SetActive(false);
                    tlobos.SetActive(false);

                }
                if (Nsejw == 3)
                {
                    Player.transform.position = sejvik3.transform.position;

                    for (int i = 0; i < gameObjects3.Length; i++)
                    {
                        //gameObjects3[i].SetActive(false);
                        //gameObjects3[i].GetComponent<Enemy>().TakeDamage(100);
                        gameObjects3[i].SetActive(true);
                    }
                    FindObjectOfType<AudioManager>().StopPlayingAll();
                    FindObjectOfType<AudioManager>().Play("tower");
                    tlo1.SetActive(false);
                    tlo2.SetActive(false);
                    tlo3.SetActive(false);
                    tlorur.SetActive(true);
                    tlobos.SetActive(false);
                }
                if (Nsejw == 4)
                {
                    Player.transform.position = sejvik4.transform.position;
                    //muzyka
                    FindObjectOfType<AudioManager>().Play("BossRoom");
                    FindObjectOfType<AudioManager>().StopPlaying("starwarsBOSS");
                    progres.GetComponent<zapelniajsieminute>().reset();
                    boss.GetComponent<boss>().reset();
                    FindObjectOfType<AudioManager>().StopPlayingAll();
                    FindObjectOfType<AudioManager>().Play("tower");
                    tlo1.SetActive(false);
                    tlo2.SetActive(false);
                    tlo3.SetActive(false);
                    tlorur.SetActive(true);
                    tlobos.SetActive(false);
                }

                blok = 0;
                health = 100;
            }
        }
    }
    public void menu(int monster,int sejw, int weapon)
    {
        supermon.mamSuper = monster;
        Nsejw=sejw;
        WeapKontrol.mam = weapon;
    }
}


