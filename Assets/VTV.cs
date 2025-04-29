using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public string PatenteDelVehiculo;
    public int ModeloDeVehiculo;
    public float KilometrosRecorridos;
    public int vencimientoVTV;
    public int HCppm;

    // Start is called before the first frame update
    void Start()
    {

        if (PatenteDelVehiculo != "")
        {
            Debug.Log(" Patente no puede estar vacia, VTV no aprobada");
            return;
        }
        else if (1900 > ModeloDeVehiculo && 2025 < ModeloDeVehiculo)
        {
            Debug.Log(" El modelo de vehiculo no es valido, VTV no aprobada");
            return;
        }
        else if (0 > KilometrosRecorridos)
        {
            Debug.Log("Los Kilometros no pueden ser negartivos, VTV no aprobada ");
            return;
        }
        else if (2025 < vencimientoVTV && vencimientoVTV > ModeloDeVehiculo)
        {
            Debug.Log(" El vencimiento VTV no es valido, VTV no aprobada");
            return;
        }
        else if (5 < HCppm && 100 > HCppm) {
            Debug.Log("Los HC ppm deben de ser mayores a 5 y menores a 100, VTV no aprobada");
            return;
        }
        else
        {
            Debug.Log(" ");
        }
        

        if ( KilometrosRecorridos / (2025 - ModeloDeVehiculo)  < 1000)
        {
            Debug.Log(" VTV otorgada por 2 años " );
        } 
        else if (KilometrosRecorridos / (2025 - ModeloDeVehiculo) > 1000)
        {
            Debug.Log("VTV otorgada por 1 año ");
        }


            
          
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
