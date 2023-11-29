using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
   // private bool state;
    public GameObject Player;
    public GameObject Canvas; 
 

    public void SceneChange()
    {
        //SceneManager.LoadScene("SampleScene"); //샘플씬으로이동 버튼에 SceneChange()연결완료  
            Player.gameObject.SetActive(true);
       
            Canvas.gameObject.SetActive(false);

    }
}
