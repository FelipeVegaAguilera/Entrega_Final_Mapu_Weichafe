using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Destroy : MonoBehaviour
{



    public void Destroyed()
    {   
        gameObject.SetActive(false);
    }
}
