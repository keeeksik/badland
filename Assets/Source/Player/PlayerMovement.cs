using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{

    public class PlayerMovement
    {
        public void Move(float xmove, Rigidbody2D rb, float speed)
        {
            rb.velocity = new Vector2 (xmove * speed, rb.velocity.y);
        }
        public void Jump(Rigidbody2D rb, float jumpForce)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
