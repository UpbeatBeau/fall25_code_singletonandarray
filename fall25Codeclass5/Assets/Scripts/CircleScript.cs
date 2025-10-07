using UnityEngine;
using UnityEngine.InputSystem;

public class CircleScript : MonoBehaviour
{
    //Variables

    //Make a Singleton
    public static CircleScript instance;

    public InputActionReference move;

    public InputActionReference interact;

    public Rigidbody2D rb;

    public float movespeed;

    private Vector2 movedirection;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movedirection = move.action.ReadValue<Vector2>();

        if (interact.action.WasPressedThisFrame())
        {
            GameManager.instance.score++;
        }
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: movedirection.x * movespeed, y: movedirection.y * movespeed);
    }
}
