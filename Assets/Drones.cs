using UnityEngine;


public class Drones : MonoBehaviour

{   
    public float speed = 0.035f;
    public float MaxY = 3.8f;
    public float MinY = -3.9f;
    bool goingUp = true;

    private float targetMax;
    private float targetMin;

    void Start()
    {
    targetMax = MaxY + Random.Range(-0.5f,0.5f);
    targetMin = MinY + Random.Range(-0.5f,0.5f);

    }

    void Update()
    {
        if (transform.position.y <= targetMin)
        {
            goingUp = true;
            targetMin = MinY + Random.Range(-0.5f,0.5f);
            
        }
        if (transform.position.y >= targetMax)
        {
            goingUp = false;
            targetMax = MaxY + Random.Range(-0.5f,0.5f);
        }

        if (goingUp)
        {
            transform.Translate(speed * Vector2.up);
        }
        else
        {
            transform.Translate(speed * Vector2.down);
        }
    }
}