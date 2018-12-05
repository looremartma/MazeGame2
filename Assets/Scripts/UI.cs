using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject menu;


	// Use this for initialization
	void Start () {
		
	}
	
    public void onStart()
    {
        menu.SetActive(false);
    }
}
