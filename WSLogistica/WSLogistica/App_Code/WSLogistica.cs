﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WSLogistica
/// </summary>
[WebService(Namespace = "BPS")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WSLogistica : System.Web.Services.WebService {

    public WSLogistica () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    
}
