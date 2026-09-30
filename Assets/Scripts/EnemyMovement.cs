using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    public float moveSpeed = 3f;

    private void Update()
    {
        enemyRb.linearVelocityX = -moveSpeed;
    }
}
