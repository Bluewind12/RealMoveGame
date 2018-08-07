using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamelaMove : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Quaternion gyro = Input.gyro.attitude;
		gyro.x *= -1;
		gyro.y *= -1;

		transform.localRotation = Quaternion.Euler (90, 0, 0) * gyro;
	}
}
