using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text2 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float typingSpeed = 0.1f;
    public float typingSpeed2 = 0.1f;
    private string GirisTexti = "Merhaba çocuklar.";
    private string text1= "                 Ben 1 tane balon almak istiyorum. Bir tane balon almama yardýmcý olabilir misin? Baloncu amcanýn balonlarýndan bir tanesini bana verir misin?";
    public bool tekbalonanimm = false;
    private string fullText;
    private int currentTextLength = 0;
    public TMP_FontAsset newFont;

    private void Start()
    {
        fullText = GirisTexti;
        StartCoroutine(TypeText(1f));

    }

    //ikinci sýradaki textin içindekileri deðiþtirmek için
    private IEnumerator TypeText(float delay)
    {
        while (currentTextLength < fullText.Length)
        {
            textMeshPro.text += fullText[currentTextLength];
            currentTextLength++;
            StartCoroutine(TypeText2(2f,12f));                                           //text atama iþlemleri ilk text
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForSeconds(delay);  
        textMeshPro.text = "";       //içini boþaltýp yenisini atýyoruz
        fullText = text1;
    }
    private IEnumerator TypeText2(float delay,float delay2) 
    {
        yield return new WaitForSeconds(delay);
        while (currentTextLength < fullText.Length)
        {
            textMeshPro.font = newFont;
            textMeshPro.color = Color.magenta;
            textMeshPro.text += fullText[currentTextLength];
            currentTextLength++;                                                       //ikinci text atama iþlemleri
            yield return new WaitForSeconds(typingSpeed2);
        }
        
        yield return new WaitForSeconds(delay2);
        gameObject.SetActive(false);
        tekbalonanimm=true;                                          //rehber balon animasyonu çýkmasý için beklenen onay
    }
    
}
