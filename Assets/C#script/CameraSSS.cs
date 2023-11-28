using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSSS : MonoBehaviour
{
    [SerializeField] Transform player; //플레이어 
    private void LateUpdate()
    {
        //카메라 고정하기 
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = targetPos;
    }
}