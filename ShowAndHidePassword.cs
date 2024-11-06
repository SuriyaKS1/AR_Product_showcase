using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;

public class ShowAndHidePassword : MonoBehaviour
{
    public TMP_InputField PasswordInputField;      

    public Button showhide;

    private bool ShowPassword = false;
    // Start is called before the first frame update
   private void Start()
    {
        showhide.onClick.AddListener(TogglePasswordVisibility);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void TogglePasswordVisibility()
    {
        ShowPassword = !ShowPassword;

        if (ShowPassword)
        {
            PasswordInputField.inputType = TMP_InputField.InputType.Standard;
        }
        else
        {
            PasswordInputField.inputType = TMP_InputField.InputType.Password;
        }
        PasswordInputField.ForceLabelUpdate();
    }
}
