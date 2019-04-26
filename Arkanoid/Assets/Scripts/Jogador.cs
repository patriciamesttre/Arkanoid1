using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 10.0f;

    public float horizontalAxis;

    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade * horizontalAxis, 0);
    }
}
