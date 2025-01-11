using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject gameOver;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Move>() != null)
            collision.gameObject.GetComponent<Move>().GameOver();
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -30, transform.position.z), moveSpeed * Time.deltaTime);
    }
    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
