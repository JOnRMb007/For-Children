using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Textwriter : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.05f;
    private string GirisTexti = "Merhaba ben Asl�. Bir baloncu amca g�rd�m. Elinde balonlar vard�. �ok merak ettim. Acaba ka� tane balonu var?";

    private string fullText;
    private int currentTextLength = 0;
    
    //asl�n�n ilk texti i�in

    private void Start()
    {
        fullText = GirisTexti;
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        while (currentTextLength < fullText.Length)
        {
            textMeshPro.text += fullText[currentTextLength];                                           //texti atama i�lemleri
            currentTextLength++;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
