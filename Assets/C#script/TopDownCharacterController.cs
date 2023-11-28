using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }



    /*
    public float speed = 5f; //�ӵ��Լ� 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��Ʈ�� k c �ּ� k u Ǯ�� 
        //�ȱ�! �� �Ʒ� �� 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += new Vector3(x, y) * speed * Time.deltaTime;//Time.deltaTim�� �����Ӹ��� �ӵ� �ٸ��� �� ������ 
    }*/
}
