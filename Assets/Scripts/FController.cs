using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FController : MonoBehaviour
{
    public static bool isActive; // �����������,��� �������� � ������ �������
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          /////Debug.Log("FloorTEST");
            isActive = true; 
            Invoke("INV", 2f);
        }

    }
    private void INV() // Invoke
    {
        //Debug.Log("False");
        isActive = false;
    }
}
