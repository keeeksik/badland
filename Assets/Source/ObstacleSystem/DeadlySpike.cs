using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObstacleSystem
{
    public class DeadlySpike : MonoBehaviour

    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "Player") 
            {
                PlayerPrefs.SetInt("lvl_index", 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Debug.Log("касается");
            }

        }
    }
}

