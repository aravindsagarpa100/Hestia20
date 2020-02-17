using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1to5 : MonoBehaviour {

	GameObject cameraPanel,cluePanel;

	public void camerabtn() {
		cameraPanel.SetActive(true);
		cluePanel.SetActive(false);
	}

	public void backbtn() {
		cameraPanel.SetActive(false);
		cluePanel.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		cameraPanel = GameObject.Find("cameraPanel");
		cluePanel = GameObject.Find("cluePanel");

		cameraPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
