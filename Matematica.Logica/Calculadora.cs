using System;

namespace Matematica.Logica
{
    public class Calculadora
    {
        public int Resta(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividendo / divisor;
        }

        public double Limitar(double numeroDecimal, double numeroLimitado)
        {
            return numeroLimitado;
        }

        public double TomarDosDecimales(double numeroConDecimales)
        {
            var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);
            return numeroPaso3;
        }


        private double MoverLaComaALaDerecha2Veces(double numeros)
        {
            return numeros * 100;
        }

        private double TomarParteEntera(double numeroPasoConDecimales)
        {
            return Math.Truncate(numeroPasoConDecimales);
        }
        private double MoverLaComaALaIzquierda2Veces(double numero)
        {
            return numero / 100;
        }

        public double TomarTresDecimales(double numeroConDecimales)
        {
            var numeroPaso1 = MoverLaComaALaDerecha3Veces(numeroConDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda3Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaIzquierda3Veces(double numeroPaso2)
        {
            return numeroPaso2 / 1000;
        }

        private double MoverLaComaALaDerecha3Veces(double numeroConDecimales)
        {
            return numeroConDecimales * 1000;
        }

        public double TomarDecimales(double numero, int numeroDeDecimales)
        {
            if (numeroDeDecimales < 0)
                throw new ArgumentException("Número de Decimales no puede ser negativo");

            var numeroPaso1 = MoverLaComaALaDerecha(numero, numeroDeDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda(numeroPaso2, numeroDeDecimales);
            return numeroPaso3;
        }

        private double MoverLaComaALaIzquierda(double numero, int numeroDeDecimales)
        {
            // 1 -> 10
            // 2 -> 100 = 10*10
            // 3 -> 1000 = 10*10*10 
            // 4 -> 10000 = 10*10*10*10
            return numero / Math.Pow(10, numeroDeDecimales);
        }

        private double MoverLaComaALaDerecha(double numero, int numeroDeDecimales)
        {
            return numero * Math.Pow(10, numeroDeDecimales);
        }

        public int AnadirEnteros(int numeroEntero1, int numeroEntero2)
        {
            var suma = numeroEntero1;
            for (var i = 0; i < numeroEntero2; i++)
            {
                suma++;
            }
            return suma;
        }

       

    }
}
