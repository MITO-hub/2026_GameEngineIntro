using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void Gotitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
    public void ButtonLog()
    {
        Debug.Log("BUTTON CLIKED");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
