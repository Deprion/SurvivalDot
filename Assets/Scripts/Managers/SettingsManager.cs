using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private GameObject exitButton;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MainScene") return;

        Instantiate(exitButton);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            settingsPanel.SetActive(!settingsPanel.activeSelf);
        }
    }
    public void ChangeSettingPanelState()
    {
        settingsPanel.SetActive(!settingsPanel.activeSelf);
    }
}
