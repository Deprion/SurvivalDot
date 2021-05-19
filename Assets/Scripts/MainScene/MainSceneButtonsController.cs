using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class MainSceneButtonsController : MonoBehaviour
{
    [SerializeField]
    private GameObject ConnectSettingsPanel;
    [SerializeField]
    private InputField ipAdress;

    private NetworkManager netMan;
    private void Awake()
    {
        netMan = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<NetworkManager>();
    }
    public void RunScene(string sceneName)
    {
        netMan.onlineScene = sceneName;
        netMan.StopClient();
        netMan.StartHost();
    }
    public void ChangeConnectSettingsPanelState()
    {
        ConnectSettingsPanel.SetActive(!ConnectSettingsPanel.activeSelf);
    }
    public void ConnectToOnline()
    {
        netMan.StopHost();
        if (!string.IsNullOrEmpty(ipAdress.text))
        {
            netMan.networkAddress = ipAdress.text;
            netMan.StartClient();
        }
    }
}
