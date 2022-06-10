using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoUm : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector3(0, - SpeedManager.GlobalSpeed * Time.deltaTime,0) );
    }
}
