using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUINavigator : MonoBehaviour
{
    private InputActions inputActions;
    [SerializeField] private CanvasGroup pauseScreen;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button settingsScreenButton;
    [SerializeField] private Button mainMenuScreenButton;

    private void Awake()
    {
        inputActions = new InputActions();
        resumeButton.onClick.AddListener((() => TogglePauseScreen()));
        mainMenuScreenButton.onClick.AddListener((() => SceneManager.LoadScene("MainMenu")));
    }
    
    private void OnEnable()
    {
        inputActions.GameplayUI.Enable();
        inputActions.GameplayUI.Pause.performed += PauseGame;
    }
    
    private void PauseGame(InputAction.CallbackContext context)
    {
        TogglePauseScreen();
    }

    private void TogglePauseScreen()
    {
        if (pauseScreen.alpha == 0)
        {
            pauseScreen.alpha = 1;
            pauseScreen.blocksRaycasts = true;
            pauseScreen.interactable = true;
        }
        else
        {
            pauseScreen.alpha = 0;
            pauseScreen.blocksRaycasts = false;
            pauseScreen.interactable = false;
        }
    }
    
    
}
