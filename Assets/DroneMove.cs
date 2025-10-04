using UnityEngine;

public class DroneMove : MonoBehaviour
{
    public float speed= 0.025f;
    public float MaxX = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x >MaxX)  {
            Destroy(gameObject);
        }
    }
}
