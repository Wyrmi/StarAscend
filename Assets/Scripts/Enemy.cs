using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject gameOver;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.GetComponent<Move>() != null) {
            Debug.Log("player hit");
            collision.gameObject.GetComponent<Move>().GameOver();
            
        }
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -30, transform.position.z), moveSpeed * Time.deltaTime);
    }
    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
