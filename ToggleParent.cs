using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleParent : MonoBehaviour
{
    public Button childButton;
    public GameObject parentObject;

    private void DisableParent()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
