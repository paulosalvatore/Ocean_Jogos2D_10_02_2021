using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 1f;

    GameObject caixaColidindo;

    GameObject caixaArrastando;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        var v = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(
            h,
            v,
            0
        );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (caixaArrastando)
            {
                caixaArrastando.transform.parent = null;

                caixaArrastando = null;
            }
            else if (caixaColidindo)
            {
                caixaArrastando = caixaColidindo;

                caixaArrastando.transform.parent = transform;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Caixa"))
        {
            caixaColidindo = other.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (caixaColidindo == other.gameObject)
        {
            caixaColidindo = null;
        }
    }
}
