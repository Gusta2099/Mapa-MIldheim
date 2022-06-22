using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    Vector3 Vec;

    // Start is called before the first frame update
    void Start()
    {
        Vec.x = 0.0f;
        Vec.y = 0.0f;
        Vec.z = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            Vec.z = 0.02f;
            Movimentacao(Vec);
            Vec.z = 0.0f;
        }
        if(Input.GetKey("a")){
            Vec.x = -0.02f;
            Movimentacao(Vec);
            Vec.x = 0.0f;
    }
    if(Input.GetKey("d")){
            Vec.x = 0.02f;
            Movimentacao(Vec);
            Vec.x = 0.0f;
    }
    if(Input.GetKey("s")){
            Vec.z = -0.02f;
            Movimentacao(Vec);
            Vec.z = 0.0f;
    }
    void Movimentacao(Vector3 Vec){
        transform.Translate(Vec);
    }
}
}