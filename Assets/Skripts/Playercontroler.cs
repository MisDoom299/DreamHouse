using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    public int speed = 20;






    void Update()

    {
        transform.Translate(new Vector3(-1,0,0) * Time.deltaTime*speed);
    }
}
    


