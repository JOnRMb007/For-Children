using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spriterendercontrol : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public GameObject balonprefab;
    public text2 activecontrol;
    int controlprefab;
    GameObject yoket;
    int index = 1;
    public GameObject balonanim;


    //balon ald�k�a asl�n�n yan�ndaki balon say�s� arts�n diye

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(activecontrol.tekbalonanimm&&index==1)
        {
            balonanim.SetActive(true);                              //balon rehberli�i animasyonu i�in
        }
        if(index==3)
        {
            balonanim.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if (activecontrol.tekbalonanimm && controlprefab<8 && yoket==null)
        {
            Instantiate(balonprefab);
            controlprefab += 1;                                                        //balonlara t�klay�nca sprite de�i�iyor   ve balon olu�turuluyor �ekmek i�in
            yoket = GameObject.Find("1-sheet_17 (1)(Clone)");                     // ekranda bir balon varken ba�ka olu�mamas� i�in 
            spriterenderoynat();
        }
        
        
    }
    
    void spriterenderoynat()
    {
        spriteRenderer.sprite = sprites[index];                                 //sprite de�i�tirme fonksiyonu
        index += 1;
    }
    
} 
