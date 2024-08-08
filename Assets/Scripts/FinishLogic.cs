using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLogic : MonoBehaviour
{
    [SerializeField] private GameObject Winpannel;
    [SerializeField] private GameObject mainmenu;
    private bool gameend = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Winpannel.SetActive(true);
            if(!gameend) 
            { 
                gameend = true;
                Invoke(nameof(GoToMainmenu),3f);
            }
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
     
    private void GoToMainmenu()
    {
        mainmenu.gameObject.SetActive(true);
    }
}
