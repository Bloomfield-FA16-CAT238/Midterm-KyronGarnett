using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour {

	public GameController GameControlr;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider other)
	{
		GameControlr.RespawnPlayer ();
	}
}
