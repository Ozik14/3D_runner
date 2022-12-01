using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public enum DeformationType 
{ 
    Width,
    Height
}
public class Gate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] Image topImage;
    [SerializeField] Image GlassImage;

    [SerializeField] Color Positivecolor;
    [SerializeField] Color Negativecolor;

    [SerializeField] int value;

    [SerializeField] DeformationType deformationType;

    [SerializeField] GameObject expandLable;
    [SerializeField] GameObject Shrinklabel;
    [SerializeField] GameObject UpLabel;
    [SerializeField] GameObject DownLabel;

    private void OnTriggerEnter(Collider other)
    {

        Modified mod = other.attachedRigidbody.GetComponent<Modified>();
        if (mod != null)
        {
            if (deformationType== DeformationType.Width)
            {
                mod.Addwidth(value);
            }
            else if (deformationType== DeformationType.Height)
            {
                mod.Addheight(value);    
            }
        }
    }
    private void OnValidate()
    {
        text.text = value.ToString();

        if (value > 0)
        {
            topImage.color = Positivecolor;
            GlassImage.color = new Color(Positivecolor.r, Positivecolor.g, Positivecolor.b, 0.5f);
        }
        else
        {
            topImage.color = Negativecolor;
            GlassImage.color = new Color(Negativecolor.r, Negativecolor.g, Negativecolor.b, 0.5f);
        }

        expandLable.SetActive(false);
        Shrinklabel.SetActive(false);
        UpLabel.SetActive(false); 
        DownLabel.SetActive(false);

        if (deformationType == DeformationType.Width)
        {
            if (value>0)
            {
                expandLable.SetActive(true);
            }
            else
            {
                Shrinklabel.SetActive(true);
            }

        }else if(deformationType == DeformationType.Height)
        {
            if (value > 0)
            {
                UpLabel.SetActive(true);
            }
            else
            {
                DownLabel.SetActive(true);
            }
        }
    }
}
   

