using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehave : MonoBehaviour
{
    private float limitTime = 2.0f; // 方向を変える時間
    private float timeCount;
    public float fishSpeed = 6; //魚の速さ
    public float escape_probability = 0.2f; //プレイヤーに気づき逃げる確率
    public Vector3 direction; //moveの進行方向

    // Start is called before the first frame update
    void Start()
    {
        direction = NormalMoveDestination();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        FishMove(fishSpeed);
        //魚が画面外へ移動移動した場合、timeCountを0に戻して、向きを反転させる
        if (transform.position.x < -9 || 9 < transform.position.x || transform.position.y < -4 || 4 < transform.position.y)
        {
            direction = Turn(direction);
        }

        //一定の時間が経過したら移動方向を変更する
        //limitTimeかtimeCountをランダムにして、方向の変更にランダム性を持たせてもいいかも
        if (timeCount > limitTime)
        {
            direction = NormalMoveDestination();
            timeCount = 0;
        }

    }

    //directionの方向へ魚を動かす
    void FishMove(float speed)
    {
        transform.position += direction * Time.deltaTime * speed;
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

 
    //画面外にいかないようにする
    Vector3 Turn(Vector3 vec)
    {
        //上下左右を反転させる
        Vector3 rev = Vector3.Reflect(vec, Vector3.up);
        return Vector3.Reflect(rev, Vector3.right);
    }

    //EnTouchから呼び出される
    //プレイヤーと円が接触した時の処理を記述する
    public void EnDetect(Vector3 vector)
    {
        if (Random.value < escape_probability)
        {
            Vector3 myvec = transform.position;
            direction = myvec - vector;
        }   
    }

    //FishTouchから呼び出される
    //プレイヤーが魚と接触したときの処理を記述する
    public void FishDetect(GameObject game)
    {
        if (Input.GetKey("f"))
        {
            Destroy(this.gameObject);
            PlayerController playerController = game.GetComponent<PlayerController>();
            playerController.GetFish();
        }
    }

}
