using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool GameIsPaused = true;
    public InputActionAsset actionAsset;
    private InputAction pauseAction;

    void Start()
    {
        DisplayWrisUI();
    }
    void Awake()
    {
        pauseAction = actionAsset.FindAction("Pause");
        pauseAction.performed += PauseButtonPressed;
        pauseAction.Enable();
    }
    void OnDestroy()
    {
        //pauseAction.Disable();
    }

    public void OnPauseButtonPressed()
    {
        InputAction.CallbackContext context = new InputAction.CallbackContext();
        PauseButtonPressed(context);
    }
    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayWrisUI();
        }
    }
    public void DisplayWrisUI()
    {
        if (pauseMenuUI != null)
        {
            if (GameIsPaused)
            {
                pauseMenuUI.SetActive(false);
                GameIsPaused = false;
                Time.timeScale = 1f;
            }
            else if (!GameIsPaused)
            {
                pauseMenuUI.SetActive(true);
                GameIsPaused = true;
                Time.timeScale = 0f;
            }
        }

    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void BackToCatalogButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}