using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stostart : MonoBehaviour
{
    public GameObject wyloncz;
    public GameObject wloncz;
    int blokuwa=0;
    // Update is called once per frame
    private void Start()
    {
        FindObjectOfType<AudioManager>().StopPlaying("divinity happy");
        FindObjectOfType<AudioManager>().Play("intro");
    }
    void Update()
    {

            if (Input.GetKey("s")&&blokuwa==0)
        {
            FindObjectOfType<AudioManager>().StopPlaying("intro");
            FindObjectOfType<AudioManager>().Play("divinity happy");
            wyloncz.SetActive(false);
        wloncz.SetActive(true);
            blokuwa = 1;
        }
    }
}
