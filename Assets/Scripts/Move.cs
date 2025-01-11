using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Move : MonoBehaviour
{
    public float posRight = 4f;
    public float posLeft = -4f;
    public float jumpSpeed = 10f;
    bool currentPosition = true;
    public GameObject gameOverCanvas;
    public GameObject enemySpawner;
    public HighScore highScore;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            currentPosition = !currentPosition;
        }
        if (currentPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(posLeft, transform.position.y, transform.position.z), jumpSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(posRight, transform.position.y, transform.position.z), jumpSpeed * Time.deltaTime);
        }

    }
    public void GameOver()
    {
        highScore.playing = false;
        gameOverCanvas.SetActive(true);
        Destroy(enemySpawner);
        Destroy(gameObject);
    }
}
