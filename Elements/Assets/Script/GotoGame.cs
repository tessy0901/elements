﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoGame : MonoBehaviour {
    public void Push()
    {
        SceneManager.LoadScene("game");
    }

}
