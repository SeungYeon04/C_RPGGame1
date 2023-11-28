using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
     //이건 키보드 움직임 아니고 마우스 바라보기용 코드!! 
{

    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _conrroller;

    private void Awake()
    {
        _conrroller = GetComponent<TopDownCharacterController>(); //찾기! 
    }


    void Start()
    {
        _conrroller.OnLookEvent += OnAim; 
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if( armRenderer.flipX = Mathf.Abs(rotZ) > 90f)
        {
            characterRenderer.flipX = armRenderer.flipX = true;

        }//아래랑 + 마우스 위치 90도 넘어가면 뒤집기!! 
        else if(armRenderer.flipX = Mathf.Abs(rotZ) < 90f)
        {
            characterRenderer.flipX = armRenderer.flipX == false;
        }//돌아오면 반대로 다시 뒤집기!! 
       
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);

    }

    void Update()
    {
        
    }
}
