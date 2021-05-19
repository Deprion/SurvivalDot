using Mirror;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    [SerializeField]
    private GameObject exitButton;

    private void Awake()
    {
        CheckScene();
    }

    private void CheckScene()
    {
        if (SceneManager.GetActiveScene().name == "MainScene") exitButton.SetActive(false);
    }

    public void LeaveToMain()
    {
        NetworkManager man = GameObject.FindGameObjectWithTag("NetworkManager").
            GetComponent<NetworkManager>();

        man.StopHost();
        man.StopClient();
    }
}
