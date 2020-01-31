using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

   public GameObject destroyEffect;

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("projectileGO");

        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            FindObjectOfType<AudioManager>().Play("projectileX");
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            if (hitInfo.collider.CompareTag("boss"))
            {
                hitInfo.collider.GetComponent<boss>().TakeDamage(damage);
            }
            if (hitInfo.collider.CompareTag("missile"))
            {
                hitInfo.collider.GetComponent<missile>().TakeDamage(damage);
            }
            if (hitInfo.collider.CompareTag("turret"))
            {
                hitInfo.collider.GetComponent<missileTurret>().TakeDamage(damage);
            }
            DestroyProjectile();
        }


        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {

        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}