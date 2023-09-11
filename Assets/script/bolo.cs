using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.UIElements.Cursor;

public class bolo : MonoBehaviour{

    public float velocidad; 
    public float velocidadRotacion;
    // Para poder asociar el componente Rigidbody (o cualquier otro que no sea transform) del GameObject..
    // PASO 1: crear una propiedad del mismo tipo del componente, PERO no la instancio
    private Rigidbody fisicas;
    
    
    void Start() {
     
        fisicas = GetComponent<Rigidbody>();
    }

    void Update() {
      
      
        var horizontal = Input.GetAxis("Horizontal"); 
        var vertical = Input.GetAxis("Vertical");
       


        var movimiento = new Vector3(horizontal, 0, vertical).normalized *
                                (Time.deltaTime * velocidad);
        transform.Translate(movimiento);

        var mouseX = Input.GetAxis("Mouse X");
        var rotacion = new Vector3(0, mouseX, 0) * (Time.deltaTime * velocidadRotacion);
        transform.Rotate(rotacion);


    }
}


