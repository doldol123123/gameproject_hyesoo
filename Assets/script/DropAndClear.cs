using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropAndClear : MonoBehaviour
{
    public Image file;
    public Image trash;
    public Image trashFull;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
         Debug.Log("아이템 충돌");
         file.gameObject.SetActive(false);
         trash.gameObject.SetActive(false);
         trashFull.gameObject.SetActive(true);


    }
}
