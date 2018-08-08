using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamelaMove : MonoBehaviour
{
	public bool debug;
	public Text Xgyro;
	public Text Ygyro;
	public Text Zgyro;
	// Use this for initialization
	void Start ()
	{
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//回転とか。
		Quaternion gyro = Input.gyro.attitude;
		gyro.x *= -1;
		gyro.y *= -1;
		transform.localRotation = Quaternion.Euler (90, 0, 0) * gyro;

		//表示（デバック用）
		if (debug) {
			Xgyro.text = "X:\t" + gyro.x;
			Ygyro.text = "Y:\t" + gyro.y;
			Zgyro.text = "Z:\t" + gyro.z;
		} else {
			Xgyro.text = "";
			Ygyro.text = "";
			Zgyro.text = "";
		}
	}
}
