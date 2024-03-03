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

    //hem ekrandaki objeyi oynatal�m diye hemde text3'�n yazmas� i�lemleri
    private void Start()
    {
        distanceToCamera = Camera.main.WorldToScreenPoint(transform.position).z;
        objectRenderer = GetComponent<Renderer>();
    }
    
    private void Update()
    {
        
        
            //ekrandakini yakalay�p hareket ettirmek i�in
            if (Input.GetMouseButtonDown(0))                                        
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))                                                           //ray i�lemleri
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
                Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);                                            //ray i�lemleri pozisyon k�sm�
                transform.position = objPosition;
            }

    }


    private void OnTriggerEnter(Collider other)
    {                             
        text3name = GameObject.Find("Canvas (1)(Clone)");                        //mesaj� yok etmek i�in yakalar�z ekrandan//
        Destroy(text3name,4f);
        Destroy(gameObject);                                                 //yakalad���m�z mesaj� bekletip yok ederiz
        objectRenderer.enabled = false;
    }

}

