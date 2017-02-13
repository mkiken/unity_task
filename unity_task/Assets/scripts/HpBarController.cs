using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		setRandomValue();
		InvokeRepeating("setRandomValue", 1.0f, 3.0f);
	}

	void setRandomValue(){
		Slider slider = GetComponent<Slider>();
		slider.value = Random.Range(slider.minValue, slider.maxValue);
	}
}
