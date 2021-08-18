using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        text.text = "残り" + indicate_Num.ToString() + "秒";

        if(countdown <= 0)
        {
            RectTransform rect = text.GetComponent<RectTransform>();
            rect.localPosition = new Vector3(50,0,0);
            text.text = "終了！";

            //タイトル画面に戻る
            if (countdown <= -10f)
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
