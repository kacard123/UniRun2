using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; // ��ֹ� ������Ʈ�� 
    private bool stepped = false; // �÷��̾� ĳ���Ͱ� ��Ҵ°�
    public int count = 100;

    // ������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        // ������ �����ϴ� ó��
        // ���� ���¸� ����
        stepped = false;

        // ��ֹ��� ����ŭ ����
        for (int i = 0; i < obstacles.Length; i++)
        {
            // ���� ������ ��ֹ��� 1/3�� Ȯ���� Ȱ��ȭ
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }

            else
            {
                obstacles[i].SetActive(false);
            }
        }

        //foreach(GameObject a in obstacles)
        //{
        //    a.SetActive(Random.Range(0, 3) == 0 ? true : false);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �÷��̾� ĳ���Ͱ� �ڽ��� ����� �� ������ �߰��ϴ� ó��
        // �浹�� ������ �±װ� Player�̰� ������ �÷��̾� ĳ���Ͱ� ���� �ʾҴٸ�
        // trigger���� ��� �浹�� ������ ���� �������� ������ tag�� ����
        // collision�� ���� ������ ������ ������ cllider�� ����.
        if(collision.collider.tag == "Player" && !stepped)
        {
            // ������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

}
