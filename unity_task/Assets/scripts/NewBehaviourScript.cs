using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

public RectTransform rect;
public RectTransform newrect;
	// Use this for initialization
	void Update () {
		newrect.sizeDelta= rect.sizeDelta;
	}
	
}
