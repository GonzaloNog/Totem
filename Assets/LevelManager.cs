using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public UiManager ui;
    public Totem player;
    private int altura = 5;
    private int multiplicador = 1;
    private float camAltura = 0;
    public int[] powerUp = null;
    public int winAltura = 900;
    private bool youWIn = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    //Set and Get
    public void setAltura(int _altura)
    {
        altura = _altura;
        if(altura >= winAltura)
            youWIn = true;
        ui.UpdateUI();
    }
    public int getAltura()
    {
        return altura;
    }
    public void setMultiplicador(int _multiplicador)
    {
        multiplicador = _multiplicador;
        ui.UpdateUI();
    }
    public int getMultiplicador()
    {
        return multiplicador;
    }
    public void setCamAltura(float  _camAltura)
    {
        camAltura = _camAltura;
    }
    public float getCamAltura()
    {
        return camAltura;
    }
    public void setYouWin(bool _youWin)
    {
        youWIn = _youWin;
    }
    public bool getYouWin()
    {
        return youWIn;
    }
}
