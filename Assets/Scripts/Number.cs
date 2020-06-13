using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    private Text numText;
    public int toolNumber;
    int mode = 0;
    // Start is called before the first frame update
    void Start()
    {
        numText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mode==0)
        numText.text = "" + FindObjectOfType<Utils>().numberDinamite[toolNumber];
    }
}
