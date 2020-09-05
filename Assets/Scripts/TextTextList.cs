using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTextList : MonoBehaviour {
    private UITextList textList;
    private int Num;
	// Use this for initialization
	void Start () {
        textList = this.GetComponent<UITextList>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Num++;
            textList.Add("dsadasdsadsadsadsadasdsasdgjkhdfgkjahkfjdgkadgadhjvhjdvbsahfahjgfhdagfhja"+Num);
        }
	}
}
