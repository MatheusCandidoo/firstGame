using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptControladorPlataforma : MonoBehaviour
{

    public GameObject plataforma;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("respaw", 0, 5);
    }


    private void respaw()
    {
        Vector2 posicao = new Vector2(24.85f, -8f);
        Instantiate(plataforma, posicao, Quaternion.identity);

    }
}
