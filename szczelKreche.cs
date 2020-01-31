using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class szczelKreche : MonoBehaviour
{
    public float _laserLength;
    public LayerMask _border;
    private LineRenderer _lineRenderer;
    float i = 0;
    public GameObject pl;
    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate()
    {
        if (_laserLength < 2)
        {
            _laserLength += 1 * Time.deltaTime;
        }
        else if(_laserLength < 40&& _laserLength >= 2)
        {
            _laserLength += 8 * Time.deltaTime;
        }
        else
        {
            _laserLength = 0;
        }
        Vector3 endPosition = (transform.right * _laserLength) + transform.position;
        _lineRenderer.SetPositions(new Vector3[] { transform.position, endPosition });

        RaycastHit2D[] hitsp = new RaycastHit2D[1];
        ContactFilter2D filterp = new ContactFilter2D();
        filterp.SetLayerMask(LayerMask.GetMask("Player"));
        filterp.useTriggers = true;
        int collidersHitp = Physics2D.Raycast(transform.position, transform.right, filterp, hitsp, _laserLength);
        if (collidersHitp > 0)
        {//zabijgracza
            pl.GetComponent<hpbar>().TakeDamage(1);
        }

    }
}
