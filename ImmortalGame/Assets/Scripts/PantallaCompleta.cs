using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
public class PantallaCompleta : MonoBehaviour
{
    public Toggle toggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { if (Screen.fullScreen)
            toggle.isOn = true;
        else
            toggle.isOn = false;
        
    }

    // Update is called once per frame
    void Update()
       
    {
        {




        }

        }
        
        
        
        
        



         public void Activarpantallacomleta(bool pantallacompleta)
    {
        Screen.fullScreen = pantallacompleta;


 


    }
}
