﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour, IPMLevelChanged {

	public string[] tasks;


	void Awake(){
		PMWrapper.SetTaskDescriptions (tasks);
	}

	// Use this for initialization
	void Start () {
		PMWrapper.numOfLevels = 14;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.K)) {
			PMWrapper.ShowGuideBubble (1, "Detta är ett mycket bra tips!");
		}
	}

	public void OnPMLevelChanged(){
		PMWrapper.AddCodeAtStart ("for i in range(4):\n\ttestcode = 0\n");

	}
}