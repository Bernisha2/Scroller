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
            float Vertical = Input.GetAxis("Vertical");
            float Horizontal = Input.GetAxis("Horizontal");

            rb.linearVelocity = new Vector2(Horizontal * speed, Vertical * speed);

            if(Input.GetButtonDown("Fire1")||Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj;
            obj = Instantiate(Bullet);
            obj.transform.position = (transform.position + offsety * Vector3.up + offsetx * Vector3.right);
            GetComponent<AudioSource>().Play();
        }
    }
}