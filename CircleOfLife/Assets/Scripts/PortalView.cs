using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalView : MonoBehaviour {

	public GameObject PlayerCamera;
	public GameObject Camera1;
	public GameObject Camera2;
	public GameObject Camera3;
	public GameObject Camera4;
	public GameObject Camera5;
	public GameObject Camera6;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Camera1.transform.rotation = PlayerCamera.transform.rotation;
		Camera2.transform.rotation = PlayerCamera.transform.rotation;
		Camera3.transform.rotation = PlayerCamera.transform.rotation;
		Camera4.transform.rotation = PlayerCamera.transform.rotation;
		Camera5.transform.rotation = PlayerCamera.transform.rotation;
		Camera6.transform.rotation = PlayerCamera.transform.rotation;
	}

	//if move to (left) camera moves opposite way
	//click on window to affect it? Hold shift to control the one that's being faced?
	// 
}
