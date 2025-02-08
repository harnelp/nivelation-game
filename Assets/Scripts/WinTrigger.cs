using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject winText; 

    void Start()
    {
        if (winText != null)
        {
            winText.SetActive(false); 
            Debug.Log("🔴 winText desactivado al inicio.");
        }
        else
        {
            Debug.LogError("❌ ¡No se ha asignado winText en el Inspector!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("➡ ALGO TOCÓ LA SALIDA: " + other.gameObject.name);

        if (other.CompareTag("Player")) 
        {
            Debug.Log("✅ EL PLAYER HA LLEGADO A LA SALIDA");

            if (winText != null)
            {
                winText.SetActive(true);
                Debug.Log("🎉 ¡Mensaje 'Ganaste' activado!");
            }
            else
            {
                Debug.LogError("❌ winText está vacío, revísalo en el Inspector.");
            }
        }
    }
}

