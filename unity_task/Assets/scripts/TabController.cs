using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabController : MonoBehaviour {
	public void OnPressChatTab(){
		PopupController.Show("Chat View");
	}
	public void OnPressCardTab(){
		PopupController.Show("Card View");
	}

}
