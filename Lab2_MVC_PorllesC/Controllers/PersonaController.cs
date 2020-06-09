using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_PorllesC.Models;

namespace Lab2_MVC_PorllesC.Controllers
{
    public class PersonaController : Controller
    {
        List<ClsPersona> objLista = new List<ClsPersona>();
        // GET: Persona
        public ActionResult Index()
        {
            //Instanciar para el objeto 1
            ClsPersona objPersona1 = new ClsPersona();
            //Instanciar los atributos de la clase
            objPersona1.apellido = "Porlles Carrillo";
            objPersona1.nombre = "Diego";
            objPersona1.email = "dporlles@upt.pe";
            objPersona1.sexo = true;
            objPersona1.edad = 22;
            objPersona1.talla = 1.65;
            //pasar el objeto a la lista
            objLista.Add(objPersona1);

            //Instanciar para el objeto 2
            ClsPersona objPersona2 = new ClsPersona();
            //Instanciar los atributos de la clase
            objPersona2.apellido = "Andia Zeballos";
            objPersona2.nombre = "Alonso";
            objPersona2.email = "aandia@upt.pe";
            objPersona2.sexo = true;
            objPersona2.edad = 21;
            objPersona2.talla = 1.74;
            //pasar el objeto a la lista
            objLista.Add(objPersona2);

            //Instanciar para el objeto 3
            ClsPersona objPersona3 = new ClsPersona();
            //Instanciar los atributos de la clase
            objPersona3.apellido = "Sosa Bedoya";
            objPersona3.nombre = "Sharon";
            objPersona3.email = "ssosa@upt.pe";
            objPersona3.sexo = false;
            objPersona3.edad = 24;
            objPersona3.talla = 1.65;
            //pasar el objeto a la lista
            objLista.Add(objPersona3);

            //Instanciar para el objeto 1
            ClsPersona objPersona4 = new ClsPersona();
            //Instanciar los atributos de la clase
            objPersona4.apellido = "Estrella Palacios";
            objPersona4.nombre = "Katherine";
            objPersona4.email = "kestrella@upt.pe";
            objPersona4.sexo = false;
            objPersona4.edad = 24;
            objPersona4.talla = 1.72;
            //pasar el objeto a la lista
            objLista.Add(objPersona4);

            return View(objLista);
        }
    }
}