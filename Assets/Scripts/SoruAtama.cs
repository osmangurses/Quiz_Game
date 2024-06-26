using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoruAtama : MonoBehaviour
{
    public static SoruAtama instance;
    public TextMeshProUGUI soruText;
    public TextMeshProUGUI[] secenekler;
    public TumSorular sorularVeCevaplar;
    public int soruSayaci = 0;

    private void Start()
    {
        instance = this;
        SoruAta();
    }
    public void SoruAta()
    {
        soruText.text = sorularVeCevaplar.sorular[soruSayaci].soru;
        soruText.transform.parent.GetComponent<Image>().color = sorularVeCevaplar.sorular[soruSayaci].color;
        for (int i = 0; i < secenekler.Length; i++)
        {
            secenekler[i].text = sorularVeCevaplar.sorular[soruSayaci].secenekler[i];
        }
    }
}
