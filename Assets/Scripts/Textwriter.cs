using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Textwriter : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.05f;
    private string GirisTexti = "Merhaba ben Aslý. Bir baloncu amca gördüm. Elinde balonlar vardý. Çok merak ettim. Acaba kaç tane balonu var?";

    private string fullText;
    private int currentTextLength = 0;
    
    //aslýnýn ilk texti için

    private void Start()
    {
        fullText = GirisTexti;
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        while (currentTextLength < fullText.Length)
        {
            textMeshPro.text += fullText[currentTextLength];                                           //texti atama iþlemleri
            currentTextLength++;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
