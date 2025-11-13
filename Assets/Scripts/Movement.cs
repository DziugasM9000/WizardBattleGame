using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10;
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
        body.velocity = new Vector2(moveDirection.x * speed, 0);
    }
}
