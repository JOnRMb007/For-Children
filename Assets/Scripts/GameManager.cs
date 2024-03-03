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
    private Vector3 nextposition = new Vector3(2.71f, -0.32f, 26.06f);          //kameran�n oynayaca�� ikinci a��
    public float moveSpeed = 5f;
    private bool hareketegec = false;
    bool hasCalledBekle = false;


    private void Start()
    {
        StartCoroutine(MesajYaz(2f));
        StartCoroutine(EnableInputAfterDelay(15f));      //asl�n�n mesaj� input bekleme s�resi
    }

    void Update()
    {
        if (canReceiveInput && Input.GetMouseButtonDown(0))
        {
            active1 = false;
            objem1.SetActive(active1);                                                //objeyi aktif etmek i�in 
            hareketegec = true;


        }
        if(hareketegec)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, nextposition, moveSpeed * Time.deltaTime);    //kameran�n istenen a��ya oynamas�
            if (!hasCalledBekle)
            {
                StartCoroutine(Bekle(1f));         //obje 2 set aktif edilmesi i�in beklenen s�re
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
    {                                                                                         //mesaj yazarken ge�ilmesin ve input al�nmas�n diye
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
