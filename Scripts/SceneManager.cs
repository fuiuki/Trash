﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScene(string other)
    {
        Application.LoadLevel(other);
    }

    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
