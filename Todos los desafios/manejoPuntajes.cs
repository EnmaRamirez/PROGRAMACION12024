﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIOS
{
    internal class manejoPuntajes
    {
        public class ManejoDepuntajes
        {
            static int puntajeRecord = 0;
            static string jugadorRecord = "";

            static void ActualizarPuntaje(int puntaje, string nombreJugador)
            {
                if (puntaje > puntajeRecord)
                {
                    puntajeRecord = puntaje;
                    jugadorRecord = nombreJugador;

                    Console.WriteLine("La nueva puntuacion más alta es " + puntajeRecord);
                    Console.WriteLine("La puntuacion más alta fue lograda por " + jugadorRecord);
                }
            }
            static void Main()
            {
                ActualizarPuntaje(250, "jugador1");
                ActualizarPuntaje(400, "jugador2");
                ActualizarPuntaje(120, "jugador3");

            }
        }
    }

}

