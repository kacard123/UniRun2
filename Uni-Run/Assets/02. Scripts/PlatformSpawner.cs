using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; // ������ ������ ���� ������
    public int count = 3; // ������ ���Ǽ� 

    public float timeBetSpawnMin = 1.25f; // ���� ��ġ������ �ð� ���� �ּڰ�
    public float tiemBetSpawnMax = 2.25f; // ���� ��ġ������ �ð� ���� �ִ�
    private float timeBetSpawn; // ���� ��ġ������ �ð� ����

    public float yMin = -3.5f; // ��ġ�� ��ġ�� �ּ� y ��
    public float yMax = 1.5f; // ��ġ�� ��ġ�� �ִ� y ��
    private float xPos = 20f; // ��ġ�� ��ġ�� x ��

    private GameObject[] platforms; // �̸� ������ ���ǵ�
    private int currentIndex = 0; // ������ ��ġ ����

    // Start is called before the first frame update
    void Start()
    {
        // ������ �ʱ�ȭ�ϰ� ����� ������ �̸� ����
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ���ư��� �ֱ������� ������ ��ġ   
    }
}
