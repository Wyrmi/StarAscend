using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("game over");
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -30, transform.position.z), moveSpeed * Time.deltaTime);
    }
    void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
