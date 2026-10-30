using System;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Button saveButton;
    public Button loadButton;
    public Button genButton;

    public static event Action OnSaveButtonPressed;
    public static event Action OnLoadButtonPressed;
    public static event Action OnGenButtonPressed;

    public static UIHandler instance;
    private void Awake()
    {
        instance = this;

        saveButton.onClick.AddListener(() => OnSaveButtonPressed.Invoke());
        loadButton.onClick.AddListener(() => OnLoadButtonPressed.Invoke());
        genButton.onClick.AddListener(() => OnGenButtonPressed.Invoke());
    }
}
