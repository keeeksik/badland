using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FinishSystem
{

    public class Finish : MonoBehaviour
    {
        private int lvlIndex;
        void Start()
        {
            lvlIndex = PlayerPrefs.GetInt("lvl_index");
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!collision.collider.CompareTag("Player"))
                return;
            lvlIndex++;
            PlayerPrefs.SetInt("lvl_index", lvlIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}


