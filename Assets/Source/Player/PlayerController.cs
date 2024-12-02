using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PlayerController : MonoBehaviour
    {
        [field: SerializeField] public float speed { get; private set; }
        [field: SerializeField] public float jumpForce { get; private set; }

        public Rigidbody2D rb;




    }
}

