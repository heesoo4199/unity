﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Exit()
	{
        Gamestrap.GSAppExampleControl.Instance.LoadScene(Gamestrap.ESceneNames.Title);
	}

}
