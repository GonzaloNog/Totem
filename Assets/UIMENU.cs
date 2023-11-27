using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMENU : MonoBehaviour
{
    public void PLAY()
    {
        SceneManager.LoadScene(1);
    }
    public void QUIT()
    {
        Application.Quit();
    }
}
