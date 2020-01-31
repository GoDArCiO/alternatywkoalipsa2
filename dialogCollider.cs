using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogCollider : MonoBehaviour
{
    public int blok = 0;
    public int numer;
    public GameObject fotka1;
    public GameObject fotka2;
    public GameObject fotka3;
    public GameObject fotka4;
    public GameObject fotka5;
    public GameObject fotka6;
    public GameObject fotka7;
    public GameObject fotka8;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //nie ma gry podczas dialogu czyli stop time, a pozatym, dialog triggeruje sie raz na gre
        //nie ma strzelania podczas dialogu czyli weapon active=0

        if (other.gameObject.CompareTag("Player")&&blok==0)
        {
            fotka1.SetActive(true);
            other.GetComponent<WeapKontrol>().wylacz();
            gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            blok = 1;
            
        }

    }
    void Update()
    {
        if (blok == 1&&numer==1)
        {
            if(DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false); fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka3.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka3.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false); fotka3.SetActive(false);  fotka1.SetActive(false); blok = 2; }

        }
        if (blok == 1 && numer == 2)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 3)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka2.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 4)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 13) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 14) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 15) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 16) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 17) { fotka2.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 5)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false); fotka3.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }//
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka3.SetActive(false); fotka1.SetActive(true); }//
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }//
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false); fotka1.SetActive(true); }//
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka3.SetActive(false); fotka1.SetActive(true); }//
            if (DialogueManager.zmiennaDialogowa == 10) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka3.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 13) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 14) { fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 15) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 16) { fotka2.SetActive(false); fotka3.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 6)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 13) { fotka2.SetActive(false);   fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 7)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 8)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false); fotka3.SetActive(false); fotka4.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka4.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka4.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 11) { fotka3.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 12) { fotka2.SetActive(false); fotka3.SetActive(false); fotka4.SetActive(false);  fotka1.SetActive(false); blok = 2; }
        }
        if (blok == 1 && numer == 9)
        {
            if (DialogueManager.zmiennaDialogowa == 1) {  fotka2.SetActive(false); fotka3.SetActive(false);  fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka3.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka3.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka3.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka3.SetActive(false);  fotka1.SetActive(false); blok = 2; }


        }
        if (blok == 1 && numer == 10)
        {
            if (DialogueManager.zmiennaDialogowa == 1) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 2) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 3) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 4) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 5) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 6) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 7) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 8) { fotka1.SetActive(false); fotka2.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 9) { fotka2.SetActive(false); fotka1.SetActive(true); }
            if (DialogueManager.zmiennaDialogowa == 10) { fotka2.SetActive(false); fotka1.SetActive(false); blok = 2; }
        }
    }
}
