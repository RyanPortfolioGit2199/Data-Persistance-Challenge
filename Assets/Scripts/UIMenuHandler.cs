using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIMenuHandler : MonoBehaviour
{
    public TMP_InputField Name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Name.onEndEdit.AddListener(NameEntered);
    }

    public void NameEntered(string text) 
    {
        Debug.Log(text);
        SaveManager.Instance.Name = text; // Gets access to playerName string variable from SaveManager. Makes the Name that the user entered be stored in SaveManager.
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
