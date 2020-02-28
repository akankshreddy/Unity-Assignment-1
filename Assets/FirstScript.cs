﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
