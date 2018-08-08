using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEventFunction : MonoBehaviour
{
	public Text testText;
	public int i = 0;

	void Start ()
	{
		testText.text = "クリック回数";
	}

	public void onClickEventTestCount ()
	{
		testText.text = "クリック回数" + i;
		i++;
	}
}
