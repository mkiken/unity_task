using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSizeFitterController : MonoBehaviour {
	public RectTransform own;
	public RectTransform target;

	// Use this for initialization
	void Start () {
		own.sizeDelta = target.sizeDelta;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
