using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CevapKontrol : MonoBehaviour
{


    public void Kontrol(int cevapIndex)
    {
        if (Zamanlayici.instance.isFailed==false)
        {
            if (cevapIndex == SoruAtama.instance.sorularVeCevaplar.sorular[SoruAtama.instance.soruSayaci].dogruSecenek)
            {
                SoruAtama.instance.soruSayaci++;
                Zamanlayici.instance.im.fillAmount += Zamanlayici.instance.artmaHizi;
            }
            else
            {
                SoruAtama.instance.soruSayaci = 0;
            }
            SoruAtama.instance.SoruAta();
        }
    }
}
