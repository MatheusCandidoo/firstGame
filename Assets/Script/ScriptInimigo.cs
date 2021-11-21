using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInimigo : MonoBehaviour
{
    public GameObject frente;
    public LayerMask mascara;
    public static float deslocamento = -0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x + deslocamento, transform.position.y );

        RaycastHit2D hit = Physics2D.Raycast(frente.transform.position, frente.transform.right, 0.1f, mascara);
        if (hit.collider != null)
        {
            transform.Rotate(new Vector2(0, 180));
            deslocamento *= -1;
        }
    }
}
