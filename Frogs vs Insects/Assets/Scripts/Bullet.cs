using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public int damage = 50;

    public float explosionRadius = 0f;
    public GameObject impactEffect;
    public float dotDamgPerTick;
    public float dotDuration = 5;
    public bool doesDotDamg;

    public void Seek (Transform newTarget)
    {
        target = newTarget;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }
    void HitTarget()
    {    
        
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
             
        if(explosionRadius > 0)
        {
            Explode();
        }
        else if(doesDotDamg == false)
        {
            Damage(damage);
        }
        if(doesDotDamg == true)
        {
            if(target.GetComponent<EnemyMovement>().hasDot == false)
            {
                target.GetComponent<EnemyMovement>().StartCoroutine(target.GetComponent<EnemyMovement>().DamageOverTime(dotDuration,dotDamgPerTick, this.gameObject));
            }
        }
        
        Destroy(gameObject);

    }
    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if(collider.tag == "Enemy")
            {
                Damage(damage);
            }
        }
    }
    void Damage(float damgToDo)    
    {
        EnemyMovement e = target.GetComponent<EnemyMovement>();
        if (e != null)
        {
            e.TakeDamage(damgToDo);
            
        }
    }

   
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
