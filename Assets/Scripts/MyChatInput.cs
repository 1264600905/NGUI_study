using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChatInput : MonoBehaviour {
    private UIInput input;
    public UITextList ChatList;
	// Use this for initialization
	void Start () {
        input = this.GetComponent<UIInput>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnChatSubmit()
    {
        string chatMessage = input.value;
        ChatList.Add("Player1:"+chatMessage);
        input.value = null;
    }
}
