using UnityEngine;


public class Script : MonoBehaviour
{
    public float scrollSpeed = 2f;       // Speed background moves left
    public float resetPosition = -20f;  
    public float startPosition = 20f;    

    void Update()
    {
        // Move background left
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
//if background not on screen reset to og position
        if (transform.position.x <= resetPosition)
        {
            Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}