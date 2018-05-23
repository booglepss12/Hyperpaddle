using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

	
	void Start () {
		
	}
	void OnMouseDrag()
	{
        print("Dragged to" + Input.mousePosition);
	}
	
	void Update () {
		
	}
}
