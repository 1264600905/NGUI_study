using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeLimit : MonoBehaviour {
    private UIInput Age;
	// Use this for initialization
	void Start () {
        Age = GetComponent<UIInput>();
	}
    public void OnValueChange() {
        string value = Age.value;
        int AgeNum = int.Parse(value);
        if (AgeNum < 18)
        {
            Age.value = "18";
        }else if (AgeNum > 120)
        {
            Age.value = "120";
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
