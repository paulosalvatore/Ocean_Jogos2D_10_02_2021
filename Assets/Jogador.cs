using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 1f;

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
    }
}
