using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularArea
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal cuadrado(decimal l)
        {
            Calcular c = new Calcular();
            c.lado = l;
            return c.cuadrado(l);
        }
        [WebMethod]
        public decimal triangulo(decimal b, decimal a)
        {
            Calcular c = new Calcular();
            c.base1 = b;
            c.altura = a;
            return c.triangulo(b, a);
        }
        [WebMethod]
        public double circulo(double r)
        {
            Calcular c = new Calcular();
            c.radio = r;
            return c.circulo(r);
        }

    }
}
