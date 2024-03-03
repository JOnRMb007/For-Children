using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class animasyon2 : MonoBehaviour
{
    private bool isDragging = false;
    private float distanceToCamera;
    public GameObject text3;
    GameObject text3name;
    Renderer objectRenderer;

    //hem ekrandaki objeyi oynatalým diye hemde text3'ün yazmasý iþlemleri
    private void Start()
    {
        distanceToCamera = Camera.main.WorldToScreenPoint(transform.position).z;
        objectRenderer = GetComponent<Renderer>();
    }
    
    private void Update()
    {
        
        
            //ekrandakini yakalayýp hareket ettirmek için
            if (Input.GetMouseButtonDown(0))                                        
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))                                                           //ray iþlemleri
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        isDragging = true;              
                    }
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                if (isDragging)
                {
                    isDragging = false;
                }
            }

            if (isDragging)
            {
                Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToCamera);
                Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                                            //ray iþlemleri pozisyon kýsmý
                transform.position = objPosition;
            }

    }


    private void OnTriggerEnter(Collider other)
    {                             
        text3name = GameObject.Find("Canvas (1)(Clone)");                        //mesajý yok etmek için yakalarýz ekrandan//
        Destroy(text3name,4f);
        Destroy(gameObject);                                                 //yakaladýðýmýz mesajý bekletip yok ederiz
        objectRenderer.enabled = false;
    }

}

