using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFunction : MonoBehaviour
{
	public GameObject mainFrame;
	public GameObject target;

	public GameObject[] image = new GameObject[4];

	private float[] mainAngle = new float[3];
	private float[] targetAngle = new float[3];

	public float xSub, ySub, zSub;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		mainAngle [0] = mainFrame.transform.localEulerAngles.x;
		mainAngle [1] = mainFrame.transform.localEulerAngles.y;
		mainAngle [2] = mainFrame.transform.localEulerAngles.z;

		targetAngle [0] = target.transform.localEulerAngles.x;
		targetAngle [1] = target.transform.localEulerAngles.y;
		targetAngle [2] = target.transform.localEulerAngles.z;

		xSub = (mainAngle [0] - targetAngle [0]) % 360;
		ySub = (mainAngle [1] - targetAngle [1]) % 360;
		zSub = (mainAngle [2] - targetAngle [2]) % 360;
	}
}
