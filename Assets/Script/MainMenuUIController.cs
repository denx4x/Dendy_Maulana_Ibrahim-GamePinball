using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour {

    public Button playButton;
    public Button exitButton;

    [SerializeField] private GameObject panelCredit;
    [SerializeField] private int indexScene;

    private void Start() {

        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);

    }

    public void PlayGame() {

        SceneManager.LoadScene(indexScene);

    }

    public void ExitGame() {
        Application.Quit();
    }

    public void ShowCredit() {

        panelCredit.SetActive(true);

    }

    public void HideCredit() {

        panelCredit.SetActive(false);

    }

}
