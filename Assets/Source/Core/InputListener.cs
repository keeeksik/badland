using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Core
{
    public class InputListener : MonoBehaviour
    {

        [SerializeField] private PlayerController player;
        private PlayerMovement playerMovement = new PlayerMovement();

        private void Move()
        {
            float xmove = Input.GetAxisRaw("Horizontal");
            playerMovement.Move(xmove, player.rb, player.speed);
        }
        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                playerMovement.Jump(player.rb, player.jumpForce);

            }

        }
        private void Update()
        {
            Move();
            Jump();
        }
    }
}
