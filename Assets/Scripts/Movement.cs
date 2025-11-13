using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f, sprintSpeed = 9f;
    public bool isRunning, canRun = true;
    private Vector2 moveDirection;
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void Move()
    {
        if (isRunning)
        {
            body.velocity = new Vector2(moveDirection.x * sprintSpeed, moveDirection.y * sprintSpeed);
        }

        else body.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}
