using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uwolnij : MonoBehaviour
{
    public Rigidbody2D rb2D;
    private void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<AudioManager>().Play("chain");
        rb2D.constraints = RigidbodyConstraints2D.None;

    }
}
