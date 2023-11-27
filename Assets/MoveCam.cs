using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    void Update()
    {
        this.transform.position = new Vector3(0.0f, LevelManager.Instance.getCamAltura(), -10.0f); ;
    }
}
