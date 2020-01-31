using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    private Transform player;
    private Vector2 target;

    public GameObject destroyEffect;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        FindObjectOfType<AudioManager>().Play("projectileGO");

        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            FindObjectOfType<AudioManager>().Play("projectileX");
            if (hitInfo.collider.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<hpbar>().TakeDamage(damage);
            }
            DestroyProjectile();
        }

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {

        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
