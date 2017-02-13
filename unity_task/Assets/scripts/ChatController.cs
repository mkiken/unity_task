using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : MonoBehaviour {
	public InputField inputField;
	public GameObject chatContents;
    public GameObject prefabChatText;

	public void onSubmitClick(){
		GameObject textObject = Instantiate(prefabChatText);
		var newText = textObject.GetComponentInChildren<Text>();
		newText.text = inputField.text;
		textObject.transform.SetParent(chatContents.transform);
		inputField.text = "";

	}

}
