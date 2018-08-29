using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEventFunction : MonoBehaviour
{
	public Text testText;
	public int score = 100;
	public GameObject targetObject;

	public Vector3 worldPos;

	public string viewString = "残り";

	void Start ()
	{
		testText.text = viewString + score;
	}

	public void clickEvent ()
	{
		
		targetObject.transform.rotation = Quaternion.Euler (Random.Range (0.0f, 360.0f), Random.Range (0.0f, 360.0f), 0);

		targetObject.GetComponent<Renderer> ().material.color = new Color (Random.value, Random.value, Random.value, 1.0f);
		score--;
		if (score <= 0) {
			testText.text = viewString + score;
		} else {
			testText.text = "おわり！";
		}
	}
}
