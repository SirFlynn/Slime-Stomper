﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenu : MonoBehaviour
{
    public void ReplayLevel ()
    {
        SceneManager.LoadScene("Level_1");
    }
}