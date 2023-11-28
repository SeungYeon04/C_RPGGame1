using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
     //�̰� Ű���� ������ �ƴϰ� ���콺 �ٶ󺸱�� �ڵ�!! 
{

    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _conrroller;

    private void Awake()
    {
        _conrroller = GetComponent<TopDownCharacterController>(); //ã��! 
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

        }//�Ʒ��� + ���콺 ��ġ 90�� �Ѿ�� ������!! 
        else if(armRenderer.flipX = Mathf.Abs(rotZ) < 90f)
        {
            characterRenderer.flipX = armRenderer.flipX == false;
        }//���ƿ��� �ݴ�� �ٽ� ������!! 
       
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);

    }

    void Update()
    {
        
    }
}
