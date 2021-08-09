using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehave : MonoBehaviour
{
    private float limitTime = 2.0f;
    private float timeCount;
    public float fishSpeed = 3;
    Vector3 direction; //moveの進行方向
    // Start is called before the first frame update
    void Start()
    {
        direction = NormalMoveDestination();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        FishMove();
        //一定の時間が経過したら移動方向を変更する
        //limitTimeかtimeCountをランダムにして、方向の変更にランダム性を持たせてもいいかも
        if(timeCount > limitTime)
        {
            direction = NormalMoveDestination();
            timeCount = 0;
        }

    }

    //directionの方向へ魚を動かす
    void FishMove()
    {
        transform.position += direction * Time.deltaTime * fishSpeed;
    }

    //ランダムに移動先を決める
    Vector3 NormalMoveDestination()
    {
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            default:
            case 0:
                return Vector3.up;
            case 1:
                return Vector3.down;
            case 2:
                return Vector3.left;
            case 3:
                return Vector3.right;
        }
    }

    //プレイヤーが魚に近づいた時の移動先を決める
    Vector3 EscapeMoveDistination()
    {
        return new Vector3(0, 0, 0); //仮
    }
}
