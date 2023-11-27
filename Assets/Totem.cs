using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    public int clicks = 10;
    public float plusCam = 1.0f;
    public Sprite newTexture;
    public Color newColor;
    public Material material;
    private int clicksActual = 0;
    private bool tocando = false;
    private bool mitad = false;
    void Start()
    {
        material.SetColor("_Color", Color.white);
    }
    private void Update()
    {
        if (!LevelManager.Instance.getYouWin())
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (tocando)
                {
                    clicksActual++;
                    if (clicksActual == clicks)
                    {
                        LevelManager.Instance.setAltura(LevelManager.Instance.getAltura() + (5 * LevelManager.Instance.getMultiplicador()));
                        Debug.Log("Altura: " + LevelManager.Instance.getAltura() + " metros");
                        clicksActual = 0;
                        newTotem();
                    }
                }
            }
            if (LevelManager.Instance.getAltura() > 10)
            {
                mitad = true;
            }
        } 
    }

    //Colisiones
    private void OnMouseEnter()
    {
        Debug.Log("Entro");
        tocando = true;
    }
    private void OnMouseExit()
    {
        Debug.Log("Salio");
        tocando = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if(collision.tag == "mitad")
        {
            Debug.Log("HOLA");
        }
    }
    public void newTotem()
    {
        this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y + (this.transform.localScale.x * LevelManager.Instance.getMultiplicador()), this.transform.localScale.z);
        if (mitad)
        {
            LevelManager.Instance.setCamAltura(LevelManager.Instance.getCamAltura() + (plusCam * LevelManager.Instance.getMultiplicador()));
        }
    }
    public void newColorON()
    {
        //GetComponent<SpriteRenderer>().color = newColor;
        material.SetColor("_Color", newColor);
    }
    public void newImageOn()
    {
        GetComponent<SpriteRenderer>().sprite = newTexture;
    }
}
