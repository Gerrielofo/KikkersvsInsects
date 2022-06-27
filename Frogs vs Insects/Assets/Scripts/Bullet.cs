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

    public static bool wantDOT;
    public float dot;
    public float dotDuration;

    public void Seek (Transform _target)
    {
        target = _target;
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
        if(explosionRadius < 0 && wantDOT == false)
        {
            Damage(target);
        }
        if(wantDOT == true)
        {
            DamageOverTime();
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
                Damage(collider.transform);
            }
        }
    }
    void Damage(Transform enemy)    
    {
        EnemyMovement e = enemy.GetComponent<EnemyMovement>();

        if(e != null)
        {
            e.TakeDamage(damage);
        }
    }

    void DamageOverTime()
    {
        if (wantDOT == false)
            return;
        if (dotDuration < 0)
        {
            ApplyDOT.doDot = true;
            ApplyDOT.dotDuration = dotDuration;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
