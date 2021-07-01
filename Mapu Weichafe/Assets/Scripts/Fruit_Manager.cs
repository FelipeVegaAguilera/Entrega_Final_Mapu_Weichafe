using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit_Manager : MonoBehaviour
{
    public Text fruits;

    public Text fruitsCollected;

    private int fruitsInLevel;

    private void Start()
    {
        fruitsInLevel = transform.childCount;

    }


    private void Update()
    {
        fruits.text = fruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }

}
