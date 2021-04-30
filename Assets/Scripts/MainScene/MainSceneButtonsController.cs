using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

public class MainSceneButtonsController : MonoBehaviour
{
    [SerializeField]
    private GameObject SettingsPanel;
    [SerializeField]
    private GameObject ConnectSettingsPanel;
    [SerializeField]
    private InputField ipAdress;

    private NetworkManager netMan;
    private void Awake()
    {
        netMan = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<NetworkManager>();
    }
    public void ChangeSettingsPanelState()
    {
        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
    }
    public void RunScene(string index)
    {
        SceneManager.LoadScene(index);
    }
    public void ChangeConnectSettingsPanelState()
    {
        ConnectSettingsPanel.SetActive(!ConnectSettingsPanel.activeSelf);
    }
    public void ConnectToOnline()
    {
        netMan.StopHost();
        if (!string.IsNullOrEmpty(ipAdress.text)) netMan.networkAddress = ipAdress.text;
        netMan.StartClient();
    }
    public void HostOnline()
    {
        netMan.StopClient();
        netMan.StartHost();
    }
}
