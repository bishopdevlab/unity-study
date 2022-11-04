# unity-study
Unity engine study

## Flappy Bird(2D 횡스크롤 게임) 클론 게임 만들기

![조코딩 JoCoding 플래피버드 클론 게임 만들기 동영상](/FlappyClone/JoCoding_FlappyBird_CloneGame.PNG)

[조코딩 - 무료 쉬운 게임 개발 강의 - 3시간만에 개발, 출시, 수익화까지 완성](https://youtu.be/EqoU1PodQQ4)

### 클론 코딩 과정 기록

클론 코딩을 하면서 정리한 내용을 폴더 내 JoCoding_FlappyBird_CloneGame.md 파일에 기록했습니다.


## Roll a ball 응용 (3D 구슬로 아이템 먹기 게임) 클론 게임 만들기

![골드메탈 유니티 강좌 기초 채널 Basic 동영상](/RollABallItemClone/Goldmetal_3DGame_RollABallApp_CloneGame.PNG)

[골드메탈 - 기초만 꾹꾹 눌러담은 3D 게임 만들기](https://youtu.be/pTc1dakebow)

### 주요 내용

1. Key 입력 제어
- Input Manager : Edit > Project Settings > Input Manager > Axes
- Keyboard, Mouse 입력 제어
```
if (Input.GetButtonDown("Jump") && !isJump)
if (Input.GetKeyDown(KeyCode.Escape))
```

2. 키보드로 공 굴리기
- 키보드 축 입력을 받아서 AddForce로 이동
```
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3 (horizontal, 0, vertical), ForceMode.Impulse);
    }
```

3. Tag 지정
- 여러 오브젝트를 Tag로 그룹핑할 수 있음. 이후 스크립트에서 tag property로 접근
```
other.tag == "Item"
```

4. 카메라가 공을 따라 다니기
- CameraMove 스크립트 생성 후 Main Camera에 스크립트 연결
- CameraMove 스크립트 작성
```
using UnityEngine;
public class CameraMove : MonoBehaviour
{
    Transform playerTansform;
    Vector3 offset;

    void Awake()
    {
        playerTansform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTansform.position;
    }

    void LateUpdate()
    {
        transform.position = playerTansform.position + offset;
    }
}
```

5. GameManager Logic
- Scene 전환
```
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);
    }
```