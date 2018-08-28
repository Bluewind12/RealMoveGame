using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEventFunction : MonoBehaviour
{
	public Text testText;
	public int score = 100;
	public GameObject targetObject;

	public string viewString = "残り";

	void Start ()
	{
		testText.text = viewString + score;
	}

	public void clickEvent ()
	{
		
		targetObject.transform.rotation = Quaternion.Euler (Random.Range (0.0f, 360.0f), Random.Range (0.0f, 360.0f), 0);

		score--;
		if (score <= 0) {
			testText.text = viewString + score;
		} else {
			testText.text = "おわり！";
		}
	}
}
