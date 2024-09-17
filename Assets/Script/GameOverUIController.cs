using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour {

    public Button mainMenuButton;
    [SerializeField] private int indexScene;

    private void Start() {
        
        mainMenuButton.onClick.AddListener(MainMenu);

    }

    public void MainMenu() {
        
        SceneManager.LoadScene(indexScene);

    }

}
