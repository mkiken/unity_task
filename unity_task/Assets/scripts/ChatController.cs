using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : MonoBehaviour {
	public InputField inputField;
	public GameObject chatContents;
    public Text prefabChatText;

	public void onSubmitClick(){
		Text newText = Instantiate(prefabChatText);
		newText.text = inputField.text;
		newText.transform.SetParent(chatContents.transform);
		inputField.text = "";

	}

}
