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


    //balon aldýkça aslýnýn yanýndaki balon sayýsý artsýn diye

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(activecontrol.tekbalonanimm&&index==1)
        {
            balonanim.SetActive(true);                              //balon rehberliði animasyonu için
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
            controlprefab += 1;                                                        //balonlara týklayýnca sprite deðiþiyor   ve balon oluþturuluyor çekmek için
            yoket = GameObject.Find("1-sheet_17 (1)(Clone)");                     // ekranda bir balon varken baþka oluþmamasý için 
            spriterenderoynat();
        }
        
        
    }
    
    void spriterenderoynat()
    {
        spriteRenderer.sprite = sprites[index];                                 //sprite deðiþtirme fonksiyonu
        index += 1;
    }
    
} 
