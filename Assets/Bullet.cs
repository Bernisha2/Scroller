using UnityEngine;

public class Bullet : MonoBehaviour
{
public float speed= 0.05f;

    private void Start()
    {
        Destroy(gameObject, .1f);
    }

    private void Update()
    {
        transform.Translate(speed*Vector2.up*Time.deltaTime);
    }
    
 private void OnTriggerEnter2D(Collider2D other)    
 { 
        if(other.CompareTag("Drone"))
        {   
        other.GetComponent<Drones>().Die();
        Destroy(gameObject);
            
        }

   }
}