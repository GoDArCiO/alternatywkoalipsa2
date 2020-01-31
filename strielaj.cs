using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strielaj : MonoBehaviour
{
    public GameObject pifpaf;
    public GameObject ja;
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        pifpaf.SetActive(true);
        FindObjectOfType<AudioManager>().Play("pifpaf");
    }
    public void elo()
    {
        x = 0;
        pifpaf.SetActive(true);
        FindObjectOfType<AudioManager>().Play("pifpaf");
    }
    // Update is called once per frame
    void Update()
    {
        if (x < 3.8f)
        {
            x += Time.deltaTime;
        }
        else
        {
            pifpaf.SetActive(false);
            ja.SetActive(false);
        }
        
    }
}
