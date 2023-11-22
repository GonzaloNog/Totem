using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    public int clicks = 10;
    private int clicksActual = 0;
    private bool tocando = false;
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (tocando)
            {
                clicksActual++;
                if(clicksActual == clicks)
                {
                    LevelManager.Instance.setAltura(LevelManager.Instance.getAltura() + 5);
                    Debug.Log("Altura: " + LevelManager.Instance.getAltura() + " metros");
                    clicksActual = 0;
                    newTotem();
                }
            }
        }
    }

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

    public void newTotem()
    {
        this.gameObject.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y + this.transform.localScale.x, this.transform.localScale.z);
    }
}
