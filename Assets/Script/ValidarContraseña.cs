using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text IngresoUsuario;
    public GameObject cartelMsj;
    public Text textoMsj;
    void Start()
    {
        contraseniaCorrecta = "Silla";
        cartelMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasenia()
    {
        contraseniaUsuario = IngresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelMsj.SetActive(true);
            textoMsj.text = "Bienvenido :)";
            Debug.Log("Bienvenido :)");
        }
        else
        {
            cartelMsj.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
