using ejemplolab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDA;

namespace ejemplolab1.DBContest
{
    public class DefaultConnection
    {
        private static volatile DefaultConnection Instance;
        private static object syncRoot = new Object();

        public ListaOriginal<Jugador> Jugadores = new ListaOriginal<Jugador>();
        public ListaOriginal<string> Ids = new ListaOriginal<string>();

        public static DefaultConnection getInstance
        {

            get{

                if (Instance == null)
                {
                    lock (syncRoot)
                    {

                        if (Instance == null)
                        {
                            Instance = new DefaultConnection();
                        }
                    }
                }
                return Instance;
            }
        }
    }
}