using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeCounter : MonoBehaviour
{
    public float countdown = 60.0f;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        float indicate_Num = Mathf.Floor(countdown);
        text.text = "Žc‚è" + indicate_Num.ToString() + "•b";

        if(countdown <= 0)
        {
            text.text = "I—¹I";
        }
    }
}
