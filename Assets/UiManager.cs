using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI altura;
    public TextMeshProUGUI multiplicador;
    public GameObject winUI;

    private void Start()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {
        altura.text = "Altura: " + LevelManager.Instance.getAltura();
        multiplicador.text = "X " + LevelManager.Instance.getMultiplicador();
        if (LevelManager.Instance.getYouWin())
            win();
    }
    public void ChangeMultiplicador()
    {
        if(LevelManager.Instance.getAltura() >= LevelManager.Instance.powerUp[0])
        {
            LevelManager.Instance.setMultiplicador(2);
        }
        if (LevelManager.Instance.getAltura() >= LevelManager.Instance.powerUp[1])
        {
            LevelManager.Instance.setMultiplicador(3);
        }
    }
    public void ChangeColor()
    {
        if(LevelManager.Instance.getAltura() >= LevelManager.Instance.powerUp[2])
            LevelManager.Instance.player.newColorON();
    }
    public void changeImage()
    {
        if (LevelManager.Instance.getAltura() >= LevelManager.Instance.powerUp[3])
            LevelManager.Instance.player.newImageOn();
    }
    public void win()
    {
        winUI.SetActive(true);
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
