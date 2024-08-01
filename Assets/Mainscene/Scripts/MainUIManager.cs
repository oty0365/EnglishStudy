using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI start;
    [SerializeField] private TextMeshProUGUI quit;
    public void StartOnHover()
    {
        start.color = Color.green;
    }

    public void StartExitHover()
    {
        start.color = Color.white;
    }
    public void QuitOnHover()
    {
        quit.color = Color.green;
    }

    public void QuitExitHover()
    {
        quit.color = Color.white;
    }

    public void StartOnClick()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }
}
