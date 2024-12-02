using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace BonusSystem
{
    public class ChangeSize : MonoBehaviour
    {
        [SerializeField] private float sizeChanging;
        [SerializeField] private float rbSizeChanging;
        Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();

        }
        private void ChangePlayerSize(int index, Collider2D obj)
        {
            transform.localScale = new Vector2(transform.localScale.x + sizeChanging * index, transform.localScale.y + sizeChanging* index);
            Destroy(obj.gameObject);
            rb.mass += rbSizeChanging * index;
        }
        private void OnTriggerEnter2D(Collider2D obj)
        {
            if (obj.tag == "Big") 
            {
                ChangePlayerSize(1, obj);
            }


            if (obj.tag == "Small")
            {
                ChangePlayerSize(-1, obj);
            }
        }
    }
}



