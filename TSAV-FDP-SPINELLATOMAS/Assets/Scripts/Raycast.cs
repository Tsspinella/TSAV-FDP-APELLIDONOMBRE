using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()

    {
        if (Input.GetButtonDown("Fire1"))
        {


            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3))
            {
                LibroSOS Libro_Magico = hit.collider.GetComponent<LibroSOS>();
                if (Libro_Magico != null)
                {
                    Libro_Magico.Desaparece();
                    source.Play();
                    
                   
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }
        }
    }

}
