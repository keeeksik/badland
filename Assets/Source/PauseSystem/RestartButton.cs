using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace PauseSystem
{
    public class RestartButton : MonoBehaviour
    {
        public GameObject pausePanel;

        public void Restart()
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}

