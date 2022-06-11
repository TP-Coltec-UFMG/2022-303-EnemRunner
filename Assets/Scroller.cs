using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

    [SerializeField]
    private RectTransform rt;
    private float posXInicial;
    private float posYInicial;
    void Start()
    {
        posXInicial = rt.transform.position.x;
        posYInicial = rt.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       if (rt.transform.position.y < 1330){
        rt.transform.position = new Vector2(posXInicial,posYInicial);

       }
       Debug.Log(rt.transform.position.y);
    }
}
