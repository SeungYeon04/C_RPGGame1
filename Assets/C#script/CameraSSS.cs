using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSSS : MonoBehaviour
{
    [SerializeField] Transform player; //�÷��̾� 
    private void LateUpdate()
    {
        //ī�޶� �����ϱ� 
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = targetPos;
    }
}