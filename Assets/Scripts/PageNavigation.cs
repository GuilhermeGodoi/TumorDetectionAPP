using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageNavigation : MonoBehaviour
{

    public void PaginaInicial()
    {
        SceneManager.LoadScene("PaginaInicial");
    }

    public void PaginaMenu()
    {
        SceneManager.LoadScene("PaginaMenu");
    }

    public void PaginaSobre()
    {
        SceneManager.LoadScene("PaginaSobre");
    }

    public void Camera()
    {
        SceneManager.LoadScene("Camera");
    }

    public void PaginaTutor()
    {
        SceneManager.LoadScene("PaginaTutor");
    }

    public void Login()
    {
        SceneManager.LoadScene("Login");
    }

    public void Registro()
    {
        SceneManager.LoadScene("Registro");
    }


}
