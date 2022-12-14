using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // 이동 속도

    void Update()
    {

        if(!GameManager.instance.isGameover)
        {
            // 초당 speed의 속도로 왼쪽으로 평행이동
            // 초당 speed의 속도로 왼쪽으로 평행이동
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            // transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            // transform.Rotate(new Vector3(-180, 0, 0) * speed * Time.deltaTime);
            //transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
            //transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            //transform.position = transform.position + (transform.right * -1) * speed * Time.deltaTime;
            //transform.position += (transform.right * -1) * speed * Time.deltaTime;
            //transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
            //transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }


}
