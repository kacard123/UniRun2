using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // �̵� �ӵ�

    void Update()
    {
        // �ʴ� speed�� �ӵ��� �������� �����̵�
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        // transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        // transform.Rotate(new Vector3(-180, 0, 0) * speed * Time.deltaTime);
    }
}
