using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroSOS : MonoBehaviour
{
    
    public void Desaparece()
    {
        
        Destroy(gameObject);
        Debug.Log("Has recolectado " + gameObject);
    }

}
