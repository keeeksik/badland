using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PauseSystem
{
    public class PauseButton : MonoBehaviour
    {
        public GameObject pausePanel;

        public void Pause()
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}

