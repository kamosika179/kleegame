using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehave : MonoBehaviour
{
    private float limitTime = 2.0f; // ������ς��鎞��
    private float timeCount;
    public float fishSpeed = 3; //���̑���
    public float escape_probability = 0.5f; //�v���C���[�ɋC�Â�������m��
    Vector3 direction; //move�̐i�s����

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
        //������ʊO�ֈړ��ړ������ꍇ�AtimeCount��0�ɖ߂��āA�����𔽓]������
        if (transform.position.x < -9 || 9 < transform.position.x || transform.position.y < -4 || 4 < transform.position.y)
        {
            direction = Turn(direction);
        }

        //���̎��Ԃ��o�߂�����ړ�������ύX����
        //limitTime��timeCount�������_���ɂ��āA�����̕ύX�Ƀ����_�������������Ă���������
        if (timeCount > limitTime)
        {
            direction = NormalMoveDestination();
            timeCount = 0;
        }

    }

    //direction�̕����֋��𓮂���
    void FishMove()
    {
        transform.position += direction * Time.deltaTime * fishSpeed;
    }

    //�����_���Ɉړ�������߂�
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

    //�v���C���[�����ɋ߂Â������̈ړ�������߂�
    Vector3 EscapeMoveDistination()
    {
        return new Vector3(0, 0, 0); //��
    }

 
    //��ʊO�ɂ����Ȃ��悤�ɂ���
    Vector3 Turn(Vector3 vec)
    {
        //�㉺���E�𔽓]������
        Vector3 rev = Vector3.Reflect(vec, Vector3.up);
        return Vector3.Reflect(rev, Vector3.right);
    }

    //EnTouch����Ăяo�����
    //�v���C���[�Ɖ~���ڐG�������̏������L�q����
    public void EnDetect()
    {
        Debug.Log("�~���Ԃ��������ߌĂт�����܂���");
    }

    public void FishDetect()
    {
        Debug.Log("�����Ԃ��������ߌĂяo����܂���");
    }

}
