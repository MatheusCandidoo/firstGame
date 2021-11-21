using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPc : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator animator;
    public float velocidade = 10;
    private float pulo;
    private bool olhandoParaDireita = true;
    private bool chao;
    public GameObject pe;
    public LayerMask mascara;
    public LayerMask plataforma;
    public LayerMask inimigo;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("entrou");
            if (ScriptControladorPlacar.placar == 1)
            {
                ScriptControladorCena.carregaMenu();
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        verificarAnimacao();
        verificarPulo();
        verificarPiso();
        verificaColisaoInimigo();
        verificaQueda();
    }

    private void verificarAnimacao()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * velocidade, rbd.velocity.y);


        if (olhandoParaDireita && x < 0)
        {
            transform.Rotate(new Vector2(0, 180));
            olhandoParaDireita = false;
        }
        else if (!olhandoParaDireita && x > 0)
        {
            transform.Rotate(new Vector2(0, 180));
            olhandoParaDireita = true;
        }

        animator.SetBool("andando", x != 0);

    }

    private void verificarPulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {

            animator.SetBool("pulando", true);
            rbd.AddForce(Vector2.up * (pulo));
        }
    }

    private void verificarPiso()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(pe.transform.position, -pe.transform.up, 0.1f, mascara);

        RaycastHit2D hit2;
        hit2 = Physics2D.Raycast(pe.transform.position, -pe.transform.up, 0.1f, plataforma);

        if (hit.collider != null)
        {

            //animator.SetBool("chao", true);
            transform.parent = hit.collider.transform;
            chao = true;
            pulo = 300;
            animator.SetBool("pulando", false);
        }
        else if(hit2.collider != null)
        {
            transform.parent = hit2.collider.transform;
            chao = true;
            pulo = 400;

            animator.SetBool("pulando", false);
        }
        else {
            chao = false;
            transform.parent = null;

            animator.SetBool("pulando", true);
        }

        

    }

    private void verificaColisaoInimigo()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(pe.transform.position, -pe.transform.up, 0.1f, inimigo);
        if(hit.collider != null)
        {
            Destroy(hit.collider.gameObject);
        }
    }

    private void verificaQueda()
    {
        if(transform.position.y <= -11)
        {
            ScriptControladorCena.carregaMenu();
            Destroy(this.gameObject);
        }
    }

}
