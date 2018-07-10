using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eConnectIntegration.CLASS
{
    public class Response
    {
        private bool _SUCCESS;
        private string _MESSAGE;
        private string _STACK;
        private string _DOCUMENT;


        /// <summary>
        /// Si la operación fue exitosa retorna True
        /// Si la operación falla retorna False
        /// </summary>
        public bool SUCCESS
        {
            get
            {
                return _SUCCESS;
            }
            set
            {
                _SUCCESS = value;
            }
        }

        /// <summary>
        /// Retorna "Exito" Si la operación fue exitosa
        /// Retorna "Error" mas la descripción del error, si la operación falla
        /// </summary>
        public string MESSAGE
        {
            get
            {
                return _MESSAGE;
            }
            set
            {
                _MESSAGE = value;
            }
        }

        /// <summary>
        /// Permanece en blanco si la operación es exitosa.
        /// Retorna el Stacktrace del .net si la operació falla
        /// </summary>
        public string STACK
        {
            get
            {
                return _STACK;
            }
            set
            {
                _STACK = value;
            }
        }

        public string DOCUMENT
        {
            get
            {
                return _DOCUMENT;
            }

            set
            {
                _DOCUMENT = value;
            }
        }
    }
}
