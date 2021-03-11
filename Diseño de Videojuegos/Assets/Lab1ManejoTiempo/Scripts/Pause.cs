using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private const KeyCode pause_Key = KeyCode.P;

    private bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pause_Key))
        {
            if (!paused)
            {
                StopGame();
            } else
            {
                ResumeGame();
            }
            paused = !paused;
        }
    }

    private void StopGame()
    {
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
