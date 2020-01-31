using UnityEngine;

public class LaserPointerDone : MonoBehaviour
{
    public float _laserLength;
    public LayerMask _border;
    private LineRenderer _lineRenderer;
    public GameObject pl;
    float i = 0;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate()
    {
        Vector3 endPosition = (transform.right * _laserLength) + transform.position;

        RaycastHit2D[] hits = new RaycastHit2D[1];

        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(LayerMask.GetMask("solid"));
        filter.useTriggers = true;
        if (i < 360)
        {
            transform.rotation = Quaternion.Euler(0, 0, i);
            i += 20 * Time.deltaTime;
        }
        else
        {
            i = 0;
        }
        // the colliders hit will be stored in hits
        int collidersHit = Physics2D.Raycast(transform.position, transform.right, filter, hits);
        if (collidersHit > 0)
        {
            _lineRenderer.SetPositions(new Vector3[] { transform.position, hits[0].point });
            _laserLength = Vector3.Distance(transform.position, hits[0].point);
        }
        else
        {
            _lineRenderer.SetPositions(new Vector3[] { transform.position, endPosition });
        }

        RaycastHit2D[] hitsp = new RaycastHit2D[1];
        ContactFilter2D filterp = new ContactFilter2D();
        filterp.SetLayerMask(LayerMask.GetMask("Player"));
        filterp.useTriggers = true;
        int collidersHitp = Physics2D.Raycast(transform.position, transform.right, filterp, hitsp, _laserLength);
        if (collidersHitp > 0)
        {//zabijgracza
            pl.GetComponent<hpbar>().TakeDamage(10);
        }
    }
}