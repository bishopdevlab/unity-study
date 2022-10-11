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
        // Prefab 생성 속도 조절
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);  // 생성
            // 간격 랜덤하게 조절
            newpipe.transform.position = new Vector3(6, Random.Range(-4f, 3.7f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f); // 메모리 관리 - 생성된 후 10초 삭제됨
        }
    }
}
