using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_CD : MonoBehaviour {
    public float CDTime=2;
    public GameObject CDLabel;
    public UISprite CDShow;
    private bool StartCD = false;
    private float CD;
	// Use this for initialization
	void Start () {
        CDShow.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)&&(StartCD!=true))
        {
            CDShow.fillAmount = 1;
            StartCD = true;
        }
        if (StartCD)
        {
            CDShow.fillAmount -= (2f / CDTime) * Time.deltaTime;
            if (CDShow.fillAmount <= 0.05)
            {
                StartCD = false;
                CDShow.fillAmount = 0;
            }
        }
        CD = CDShow.fillAmount * CDTime;
        CDLabel.GetComponent<UILabel>().text =CD.ToString("0.0");
    }
}
