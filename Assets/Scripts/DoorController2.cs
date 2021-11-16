using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    ///////////// ������ �����
    



    Animation anim;

    public GameObject Player;
    public bool isActive;



    void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void Update()
    {
        isActive = FController.isActive; // ��������� � FController
        Door();
    }



    public void Door()
    {
        if (isActive)
        {
            anim.Play("Right"); // ������ ��������
         //   Debug.Log("activate Right");
            isActive = false; 
        }
    }

  /*  private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          //  Debug.Log("Door Right");
            isActive = true;
        }
    }*/

}
