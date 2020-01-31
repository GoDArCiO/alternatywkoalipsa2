using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wroc : MonoBehaviour
{
    private Vector3 gdzie;
    private Quaternion rotacja;
    // Start is called before the first frame update
    private void Start()
    {
        gdzie = transform.position;
        rotacja = transform.rotation;
    }

        // Update is called once per frame
        public void Wracanko()
    {
        transform.position = gdzie;
        transform.rotation = rotacja;
    }
}
