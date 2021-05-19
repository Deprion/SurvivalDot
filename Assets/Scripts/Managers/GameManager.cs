using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanelPrefab;
    private GameObject settingsPanel;

    private void Awake()
    {
        GameObject[] temp = GameObject.FindGameObjectsWithTag("GameManager");
        if (temp.Length > 1) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        SpawnObjects();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel")) ChangeSettingPanelState();
    }
    public void ChangeSettingPanelState()
    {
        if (settingsPanel == null) SpawnObjects();
        settingsPanel.SetActive(!settingsPanel.activeSelf);
    }
    private void SpawnObjects()
    {
        GameObject mainCanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        settingsPanel = Instantiate(settingsPanelPrefab, mainCanvas.transform, false);
    }
}
