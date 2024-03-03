using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class balonsayısı : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public spriterenderer2 balonsayisi;
    string balonsayisistring;
    public GameObject textfinish;
    bool control = true;
    AudioSource audioSource;

    //balonsayısı sayacı

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(balonsayisi.balonsayısı != 0)                      //balon sayısı sıfır değil ise yazmaya başlıyor
        balonsayisistring=balonsayisi.balonsayısı.ToString();                             //balonsayısını diğer scriptten aldığımız için dönüştüroyurz
        textMeshPro.text = balonsayisistring;                                //vede ekrana yazma işlemi

        if(balonsayisi.balonsayısı==8&&control)
        {
            Instantiate(textfinish);
            control = false;
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }

    }

}
