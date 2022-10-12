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

    // �ʹݿ� ������ ������ ȭ�� �ۿ� ���ܵ� ��ġ
    private Vector2 poolPosition = new Vector2(0, -25);
    private float lastSpawnTime; // ������ ��ġ ����

    // Start is called before the first frame update
    void Start()
    {
        // ������ �ʱ�ȭ�ϰ� ����� ������ �̸� ����

        // count��ŭ�� ������ ������ ���ο� ���� �迭 ����
        platforms = new GameObject[count];

        // count��ŭ �����ϸ鼭 ���� ����
        for(int i = 0; i < count; i++)
        {
            // platformPrefab�� �������� �� ������ poolPosition ��ġ�� ���� ����
            // ������ ������ platform �迭�� �Ҵ�
            platforms[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
        }
        // ������ ��ġ ���� �ʱ�ȭ
        lastSpawnTime = 0f;
        // ������ ��ġ������ �ð� ������ 0���� �ʱ�ȭ
        timeBetSpawn = 0f;
    }

    void Update()
    {
        // ������ ���ư��� �ֱ������� ������ ��ġ
        // ���� ���� ���¿����� �������� ����
        if(GameManager.instance.isGameover) // Ÿ��.��������.
        {
            return; // �Ʒ��� ���� ���� �ʰ� ���� ���� ��ȯ�Ѵ�. 
        }

        // ������ ��ġ �������� timeBetSpawn �̻� �ð��� �귶�ٸ�
        if(Time.time >= lastSpawnTime + timeBetSpawn)
        {
            // ��ϵ� ������ ��ġ ������ ���� �������� ����
            lastSpawnTime = Time.time;

            // ���� ��ġ������ �ð� ������ timeGetSpawnMin, timeBetSpawnMax ���̿��� ���� ����
            timeBetSpawn = Random.Range(timeBetSpawnMin, tiemBetSpawnMax);

            // ��ġ�� ��ġ�� ���̸� yMin�� yMax ���̿��� ���� ����
            float yPos = Random.Range(yMin, yMax);

            // ����� ���� ������ ���� ���� ������Ʈ�� ��Ȱ��ȭ�ϰ� ��� �ٽ� Ȱ��ȭ
            // �̶� ������ Platform ������Ʈ�� OnEnable �޼��尡 �����
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            // ���� ������ ������ ȭ�� �����ʿ� ���ġ
            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            // ���� �ѱ��
            currentIndex++;

            // ������ ������ �����ߴٸ� ������ ����
            if(currentIndex >= count)
            {
                currentIndex = 0;
            }
        }
    }
}
