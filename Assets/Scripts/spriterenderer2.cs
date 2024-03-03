using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriterenderer2 : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    int index = 0;
    public int balonsay�s�;
    AudioSource audioSource;
    public GameObject text3;
    GameObject text3object;
    bool control = true;


    //balon ald�k�a balonlar�n azalmas�n� g�stermek i�in


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[index];
        audioSource = GetComponent<AudioSource>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        index++;
        balonsay�s� = index;                                          //sprite de�i�iyor
        if (index < sprites.Length)
        {
            spriteRenderer.sprite = sprites[index];
        }
        if (audioSource != null)
        {
            audioSource.Play();
        }
        text3object=GameObject.Find("Canvas (1)(Clone)");
        if(control)
        {
            Instantiate(text3);
            Destroy(text3object, 4f);
            control = false;
        }
        
        
        
    }
}
