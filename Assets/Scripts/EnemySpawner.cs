using UnityEngine;
using System.Collections;
using UnityEditor.ShaderGraph.Internal;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform spawnpointLeft;
    public Transform spawnpointRight;
    public float spawnInterval = 1f;

    [SerializeField]
    private float minInterval;

    private float offsetX;
    private float offsetY;

    void Start()
    {
        StartCoroutine("SpawnObstacles");
    }
    IEnumerator SpawnObstacles()
    {
        if (enemies == null || enemies.Length == 0)
            Debug.Log("no enemies in spawner");
        else
        {
            while (true)
            {
                yield return new WaitForSeconds(spawnInterval);
                offsetX = Random.Range(-1f,1f);
                offsetY = Random.Range(-0.5f,0.5f);
                if(Random.Range(0,2) == 0)
                    Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector3(spawnpointLeft.position.x + offsetX, spawnpointLeft.position.y + offsetY, spawnpointLeft.position.z), transform.rotation);
                else
                    Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector3(spawnpointRight.position.x + offsetX, spawnpointRight.position.y + offsetY, spawnpointRight.position.z), transform.rotation);
            }
        }
    }
}
