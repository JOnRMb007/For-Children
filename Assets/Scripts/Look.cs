using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform hedef;

    //karakterler kameraya baks�n diye

    void Update()
    {
        transform.LookAt(hedef);                    
    }
}
