using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameGrade
{
    Esay,
    Normal,
    Hard
}
public enum ControlType
{
    Keyboard,
    Touch,
    Mouse
}
public class GameSetting : MonoBehaviour {
    public GameObject OptionPanel;
    public GameObject StartPanel;
    public  float volume = 1;
    public  GameGrade grade = GameGrade.Normal;
    public  ControlType controlType = ControlType.Keyboard;
    public  bool isFullscreen = false;
    public void onVoiceChange()
    {
        volume = UISlider.current.value;
        print("音量:"+volume);
    }
    public void onLevelChange()
    {
        switch (UIPopupList.current.value)
        {
            case "Easy":
               grade= GameGrade.Esay;
                break;
            case "Normal":
                grade = GameGrade.Normal;
                break;
            case "Hard":
                grade = GameGrade.Hard;
                break;
        }
        print("难度为："+ UIPopupList.current.value);
    }
    public void onControlChange()
    {
        switch (UIPopupList.current.value)
        {
            case "Mouse":
                controlType = ControlType.Mouse;
                break;
            case "Keyboard":
                controlType = ControlType.Keyboard;
                break;
            case "Touch":
                controlType = ControlType.Touch;
                break;
        }
        print("操作方式："+ UIPopupList.current.value);
    }
    public void isFullSreenChange()
    {
        print("是否全屏："+ UIToggle.current.value);
        isFullscreen = UIToggle.current.value;
    }
    public void OnStartButtonClick()
    {

    }
    public void OnSettingButtonClick()
    {
        OptionPanel.GetComponent<TweenPosition>().PlayForward();
        StartPanel.GetComponent<TweenPosition>().PlayForward();
    }
    public void OnExitButtonClick()
    {
        print("GameExit");
    }
    public void OnDownButtonClick()
    {

        OptionPanel.GetComponent<TweenPosition>().PlayReverse();
        StartPanel.GetComponent<TweenPosition>().PlayReverse();
    }
}
