using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    private int altura = 5;
    private int multiplicador = 1;


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
    }
    public int getAltura()
    {
        return altura;
    }
    public void setMultiplicador(int _multiplicador)
    {
        multiplicador = _multiplicador;
    }
    public int getMultiplicador()
    {
        return multiplicador;
    }
}
