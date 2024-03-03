using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text3 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.05f;
    private string GirisTexti = "Harika hadi devam edelim";

    private string fullText;
    private int currentTextLength = 0;
    
    //harika mesaj�n�n� ayzd�rmak i�in

    private void Start()
    {
        fullText = GirisTexti;
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        while (currentTextLength < fullText.Length)
        {
            textMeshPro.text += fullText[currentTextLength];
            currentTextLength++;                                                                  //texti atama i�lemleri
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
