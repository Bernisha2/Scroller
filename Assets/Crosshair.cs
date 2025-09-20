using UnityEngine;


public class Crosshair : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    private float offsetx = 0f;
    private float offsety = 0f;
    public GameObject Bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

            if (Input.GetKey(KeyCode.W))
                moveY = 1f;
            else if (Input.GetKey(KeyCode.S))
                moveY = -1f;
        

            if (Input.GetKey(KeyCode.UpArrow))
                moveY = 1f;
            else if (Input.GetKey(KeyCode.DownArrow))
                moveY = -1f;
        
 
            if (Input.GetKey(KeyCode.A))
                moveX = -1f;
            else if (Input.GetKey(KeyCode.LeftArrow))
                moveX = -1f;
                
                if (Input.GetKey(KeyCode.D))
                moveX = 1f;
            else if (Input.GetKey(KeyCode.RightArrow))
                moveX = 1f;

            rb.linearVelocity = new Vector2(moveX * speed,moveY * speed);

            if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj;
            obj = Instantiate(Bullet);
            obj.transform.position = (transform.position + offsety * Vector3.up + offsetx * Vector3.right);
            GetComponent<AudioSource>().Play();
        }
    }
}