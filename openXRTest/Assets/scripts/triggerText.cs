using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerText : MonoBehaviour
{



    public GameObject InfoTextObject;
    void Start()
    {
        InfoTextObject.SetActive(false);
             
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("epipen"))
        {
            InfoTextObject.SetActive(true); 
            StartCoroutine(End()); 
            
            
        }
        Invoke("QuitGame", 0.3f); 
        QuitGame();
                    
    }
void QuitGame()
        { 
            Application.Quit();
        }
    IEnumerator End()
    {
        yield return new WaitForSeconds(5);
        InfoTextObject.SetActive(false);

    }


}
