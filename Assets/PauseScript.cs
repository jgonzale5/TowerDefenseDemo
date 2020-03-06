using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
    }

    public void PauseToggle(bool to)
    {
        if (to)
            Pause();
        else
            UnPause();
    }

    public void ChangeTimeScale(float to)
    {
        Time.timeScale = to;
    }
}
