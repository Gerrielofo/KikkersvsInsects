using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10f;

    public int health = 100;

    public int gainMoney = 25;

    public GameObject deathEffect;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = Waypoint.points[0];
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        PlayerStats.money += gainMoney;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 2f);

        Destroy(gameObject);

        WaveSystem.enemiesAlive -= 1;
        Debug.Log(WaveSystem.enemiesAlive.ToString() + " enemies alive");
    }
    private void Update()
    {
        if (OptionsUI.wantOptions == true)
        {
            //Debug.Log("enemy movement paused");
            return;
        }
            

        if (GameManager.GameIsOver == true)
            return;

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position)<= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoint.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoint.points[wavepointIndex];
        transform.LookAt(Waypoint.points[wavepointIndex]);
    }
    void EndPath()
    {
        PlayerStats.Lives -= 5;
        Destroy(gameObject);
        return;
    }
}
