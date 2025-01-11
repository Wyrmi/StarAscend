using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform spawnpointLeft;
    public Transform spawnpointRight;
    public float spawnInterval = 1f;


    void Start()
    {
        StartCoroutine("SpawnObstacles");
        Debug.Log("spawnEnd ");
    }
    IEnumerator SpawnObstacles()
    {
        if (enemies == null || enemies.Length == 0)
            Debug.Log("no obstacles in spawner");
        else
        {
            while (true)
            {
                yield return new WaitForSeconds(spawnInterval);
                if(Random.Range(0,2) == 0)
                    Instantiate(enemies[Random.Range(0, enemies.Length)], spawnpointLeft.position, transform.rotation);
                else
                    Instantiate(enemies[Random.Range(0, enemies.Length)], spawnpointRight.position, transform.rotation);
            }
        }
    }
}
