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


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            currentPosition = !currentPosition;
        }
        if (currentPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(posLeft, 0, 0), jumpSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(posRight, 0, 0), jumpSpeed * Time.deltaTime);
        }

    }
}
