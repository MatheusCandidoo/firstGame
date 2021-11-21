using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptControladorPlacar : MonoBehaviour
{
    public static int placar = 0;
    public static Text txtPlacar;
    public static Text txtTeste;
    // Start is called before the first frame update

    public void Start()
    {
        txtPlacar = GameObject.Find("Text").GetComponent<Text>();
    }


    public static void adicionaPontos(int a)
    {
        placar += a;
        txtPlacar.text = "X " + placar;
    }
}
