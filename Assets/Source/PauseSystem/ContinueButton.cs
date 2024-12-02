using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PauseSystem
{
    public class ContinueButton : MonoBehaviour
    {
        public GameObject pausePanel;

        public void Continue()
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1.0f;
        }


    }
}

