using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    public GameObject objem1;
    public GameObject objem2;
    bool active1 = true;
    bool active2 = false;
    bool canReceiveInput = false;
    public Camera cam;
    private Vector3 nextposition = new Vector3(2.71f, -0.32f, 26.06f);          //kameranýn oynayacaðý ikinci açý
    public float moveSpeed = 5f;
    private bool hareketegec = false;
    bool hasCalledBekle = false;


    private void Start()
    {
        StartCoroutine(MesajYaz(2f));
        StartCoroutine(EnableInputAfterDelay(15f));      //aslýnýn mesajý input bekleme süresi
    }

    void Update()
    {
        if (canReceiveInput && Input.GetMouseButtonDown(0))
        {
            active1 = false;
            objem1.SetActive(active1);                                                //objeyi aktif etmek için 
            hareketegec = true;


        }
        if(hareketegec)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, nextposition, moveSpeed * Time.deltaTime);    //kameranýn istenen açýya oynamasý
            if (!hasCalledBekle)
            {
                StartCoroutine(Bekle(1f));         //obje 2 set aktif edilmesi için beklenen süre
                hasCalledBekle = true; 
            }
        }
        
    }


    private IEnumerator MesajYaz(float delay)
    {
        yield return new WaitForSeconds(delay);
        objem1.SetActive(active1);
    }

    private IEnumerator EnableInputAfterDelay(float delay2)
    {                                                                                         //mesaj yazarken geçilmesin ve input alýnmasýn diye
        yield return new WaitForSeconds(delay2);
        canReceiveInput = true;
    }
   
    private IEnumerator Bekle(float delay3)
    {
        yield return new WaitForSeconds(delay3);
        active2 = true;
        objem2.SetActive(active2);
    }
    



}
