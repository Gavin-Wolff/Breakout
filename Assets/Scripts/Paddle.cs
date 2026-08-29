using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 10f;
    
 private void Update()
    {
    float movement = processInput();
    movePaddle(movement);
    }


private float processInput()
    {
        float movement = 0f;
        movement = Input.GetAxis("Player");

        return movement;
    }

    private void movePaddle(float value)
    {
      rb.linearVelocity = new Vector2(value * MoveSpeed, 0);
    }

}