
using System.Collections.Generic;
using System;

namespace StoreList
{
    public class Stack
    {
        private readonly List<object> _list= new List<object>();

        public void Push()
        {
            Console.WriteLine("\n\nIntroduce los datos que quieras almacenar en la lista, " +
                "presiona 'E' cuando quieras dejar de introducir datos");
            
            while (true)
            {
                _list.Insert(0,Console.ReadLine());

                if (_list[0].ToString() == "e")
                {
                    _list.Remove("e");
                    break;
                }
                else if (string.IsNullOrEmpty(_list[0].ToString()))
                {
                    Console.WriteLine("\n********************No se puede introducir datos nulos o empty string a la lista*************************");
                    _list.Remove(_list[0]);
                    break;
                }
            }

            Eleccion();
   
        }

        public object Pop()
        {
            return _list[0];
        }

        public void Clear()
        {
            Console.WriteLine("\n********************La lista ya esta vacia***********************************");
            _list.Clear();
            Eleccion();
            
        }

        public void Eleccion()
        {
            Console.WriteLine("\nPara continuar introduciendo datos a la lista presiona 'A', para mostrar el valor top de la lista presiona 'M'" +
                "y para limpiar la lista presiona 'C'");

            string answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "a":
                    Push();
                    break;


                case "m":
                    Console.WriteLine("\nPresiona 'enter' para ir mostrando el valor top de la lista, presiona 'e' para salir ");
                    Console.WriteLine("\n La lista tiene un total de {0} elementos", _list.Count);
                    var take = Console.ReadLine();

                    while (true)
                    {
                        if (take.ToLower() == "e")
                        {
                            break;
                        }
                        else
                        {
                            if (_list.Count == 0)
                            {
                                Console.WriteLine("\n********************La lista no contiene mas elementos***********************************");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(Pop());
                                _list.Remove(_list[0]);
                                Console.ReadKey();
                            }
                        }
                    }
                    Eleccion();
                    break;


                case "c":
                    Clear();
                    break;
            }
        }
    }
}
