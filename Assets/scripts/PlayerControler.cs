using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dodaj do współrzędnych wartość x=1, y=0, z =0 * czas w mierzony w sekundy ostatniej klatki
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja działania wygładzonego sterowania(emualcja joysticka)
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie prędkośią
        //stwórz nowy vector przesunięcia o wartość 1 do przodu
        Vector3 movment = Vector3.forward;
        //pomnóż przez czas 
        movment*= Time.deltaTime;
        //pomnóż go przez "wychylenie joysticka"
        movment *= Input.GetAxis("Vertical");
        //dodaj ruch obiektu
        transform.position += movment;

        //obrót
        //modyfikuj  "Y" obiektu player
        Vector3 rotation = Vector3.up;
        //przemnó¿ przez czas
        rotation *= Time.deltaTime;
        //przemnó¿ przez klawiaturê
        rotation *= Input.GetAxis("Horizontal");
        //pomnóż prędkość obrotu
        rotation *= rotationSpeed;
        //dodaj obrót do obiektu
        //nie mozemy uzywac += poniewa¿ unity u¿ywa Quaternionów do zapisu rotacji
        transform.Rotate(rotation);

    }
}
