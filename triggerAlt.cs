using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAlt : MonoBehaviour
{
    public GameObject[] gameObjects;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }

    }
}
