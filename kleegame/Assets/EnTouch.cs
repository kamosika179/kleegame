using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnTouch : MonoBehaviour
{
    public string playerTag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //プレイヤーが近づくと魚が逃げる判定
    //実際の処理はFishBehaveのEnDetectに記述する。こっちはあたり判定のみ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == playerTag)
        {
            Debug.Log("円のトリガーです");
            Vector3 vec = collision.GetComponent<Collider2D>().transform.position;
            transform.root.gameObject.GetComponent<FishBehave>().EnDetect(vec);
        }
    }
}
