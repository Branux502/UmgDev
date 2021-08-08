using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication.App_Code.Models
{
    public class ClsBiblioteca
    {
        private int idLibro;
        private string name;

        public int IdLibro
        {
            get
            {
                return idLibro;
            }

            set
            {
                idLibro = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}