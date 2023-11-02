using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaShrink : MonoBehaviour
{
    public float shrinkSpeed = 0.1f;
    public TMP_Text text;

    void Update()
    {
        StartCoroutine(Shrink());    
    }

    IEnumerator Shrink()
    {
        yield return new WaitForSeconds(20);
        this.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(-50, -50, 0), Time.deltaTime * shrinkSpeed);
    }
}