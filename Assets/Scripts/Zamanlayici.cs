using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zamanlayici : MonoBehaviour
{
    public static Zamanlayici instance;
    public float azalmaHizi;
    public float artmaHizi;
    public Image im;
    public bool isFailed;
    private void Start()
    {
        instance = this;
        im = GetComponent<Image>();
    }
    void Update()
    {
        im.fillAmount-=azalmaHizi*Time.deltaTime;
        if (im.fillAmount<=0)
        {
            isFailed = true;
        }
    }
}
