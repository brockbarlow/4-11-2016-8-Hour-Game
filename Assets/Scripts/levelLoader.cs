﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour {

    public static int currentLevel = 2;

    public static void nextLevel()
    {
        if (currentLevel < 5)
        {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
        }
    }
}