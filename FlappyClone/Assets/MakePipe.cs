using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Prefab ���� �ӵ� ����
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);  // ����
            // ���� �����ϰ� ����
            newpipe.transform.position = new Vector3(6, Random.Range(-6f, 1.7f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f); // �޸� ���� - ������ �� 10�� ������
        }
    }
}