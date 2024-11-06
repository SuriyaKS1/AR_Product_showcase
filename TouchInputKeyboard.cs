using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.iOS;

public class NewBehaviourScript : MonoBehaviour
{
    public  TMP_InputField Username;
    public TMP_InputField Password;
    private TouchScreenKeyboard keyboard;

    private bool IsUsernameClicked = false ;
    private bool IsPasswordClicked = false ;

    protected void Update(){

    
        if(IsUsernameClicked) {
            keyboard = TouchScreenKeyboard.Open(Username.text, TouchScreenKeyboardType.Default);
            IsUsernameClicked = false;
        }
        if(IsPasswordClicked){
            keyboard = TouchScreenKeyboard.Open(Password.text, TouchScreenKeyboardType.Default);
            IsPasswordClicked = false;
        }
    }
    public void OnUsernameClicked(){
        IsUsernameClicked = true ;
    }
    public void OnPasswordClicked(){
        IsPasswordClicked = true ;
    }
}
