using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptChave : MonoBehaviour
{
    private float velocidade = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector2(0, velocidade));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScriptControladorPlacar.adicionaPontos(1);
            Destroy(this.gameObject);
        }
    }
}
