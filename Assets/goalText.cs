using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalText: MonoBehaviour
{
    public Text mytext = null;
    // Start is called before the first frame update
    void Start()
    {
        mytext.text = "จุดหมายปลายทาง: M78";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
