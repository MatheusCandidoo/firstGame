using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlataforma : MonoBehaviour
{
    private float deslocamento = 0.015f;
    

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x, transform.position.y+deslocamento);
        if(transform.position.y >= 30.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
