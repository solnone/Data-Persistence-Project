using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class InitNameField : MonoBehaviour
{
    private TMP_InputField nameField;
    public SessionManager sessionManager;

    void Start()
    {
        nameField = GetComponent<TMP_InputField>();
        nameField.text = sessionManager.data.Name;
    }

}
