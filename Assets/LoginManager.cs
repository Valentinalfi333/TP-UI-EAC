using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManager : MonoBehaviour
{
    public InputField contraseña;

    public void MostrarEnConsola()
    {
        string contraseñareal = "miguelito";
        if (contraseña.text == contraseñareal) {
            Debug.Log("Acceso garantizado");
        }
        else
        {
            Debug.Log("Acceso denegado");
        }
    }
}
