﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}