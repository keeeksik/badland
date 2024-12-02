using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObstacleSystem
{
    public class AxisRotate : MonoBehaviour
    {
        [SerializeField] float speed = 3;
        [SerializeField] Vector3 axis = new Vector3(0, 0, 1);
        [SerializeField] Transform point;


        void Update()
        {
            transform.RotateAround(point.position, axis, speed * Time.deltaTime);
        }
    }
}

