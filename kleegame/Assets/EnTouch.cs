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

    //�v���C���[���߂Â��Ƌ��������锻��
    //���ۂ̏�����FishBehave��EnDetect�ɋL�q����B�������͂����蔻��̂�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == playerTag)
        {
            Debug.Log("�~�̃g���K�[�ł�");
            Vector3 vec = collision.GetComponent<Collider2D>().transform.position;
            transform.root.gameObject.GetComponent<FishBehave>().EnDetect(vec);
        }
    }
}
