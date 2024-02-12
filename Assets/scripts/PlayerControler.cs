using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dodaj do wsp�rz�dnych warto�� x=1, y=0, z =0 * czas w mierzony w sekundy ostatniej klatki
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        //prezentacja dzia�ania wyg�adzonego sterowania(emualcja joysticka)
        //Debug.Log(Input.GetAxis("Vertical"));

        //sterowanie pr�dko�i�
        //stw�rz nowy vector przesuni�cia o warto�� 1 do przodu
        Vector3 movment = Vector3.forward;
        //pomn� przez czas 
        movment*= Time.deltaTime;
        //pomn� go przez "wychylenie joysticka"
        movment *= Input.GetAxis("Vertical");
        //dodaj ruch obiektu
        transform.position += movment;

        //obr�t

    }
}
