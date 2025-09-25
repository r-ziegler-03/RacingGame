using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigator : MonoBehaviour
{
    [SerializeField] private ScreenSwitcher screenSwitcher;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button setupRaceButton;
    [SerializeField] private Button settingsBackToMainMenuButton;
    [SerializeField] private Button selectionBackToMainMenuButton;
    [SerializeField] private Button startRaceButton;


    private void Awake()
    {
        settingsButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Settings));
        setupRaceButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Selection));
        settingsBackToMainMenuButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Menu));
        selectionBackToMainMenuButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Menu));
        startRaceButton.onClick.AddListener(() => SceneManager.LoadScene("Gameplay"));
    }
}
