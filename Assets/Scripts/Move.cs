using UnityEngine;

public class Move : MonoBehaviour
{
    public float posRight = 4f;
    public float posLeft = -4f;
    bool currentPosition = true;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (currentPosition) {
                transform.position = new Vector3(posRight, 0, 0);
            }
            else
            {
                transform.position = new Vector3(posLeft, 0, 0);
            }
            currentPosition = !currentPosition;
        }

    }
}
