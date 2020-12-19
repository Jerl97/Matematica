using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Logica;
using System;

namespace Matematica.Test
{	
	// Atributo o Metadata
	[TestClass]

	public class CalculadoraTest
	{
		private TestContext testContextInstance;
		public TestContext TestContext
		{
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}

		[TestMethod]
		public void RestaDosNumeros()
		{
			// arrange ->preparación 
			var minuendo = 10;
			var sustraendo = 5;
			var esperado = 5;

			// act ->esta es la parte de ejecución
			var calculadora = new Calculadora();
			var respuestaObtenida = calculadora.Resta(minuendo, sustraendo);

			// assert -> verificación
			Assert.AreEqual(esperado, respuestaObtenida);
		}

		[TestMethod]
		public void SumaDosNumeros()
		{
			// arrange ->preparación 
			var numero1 = 7;
			var numero2 = 10;
			var esperado = 17;

			// act ->esta es la parte de ejecución
			var calculadora = new Calculadora();
			var respuestaObtenida = calculadora.Sumar(numero1, numero2);

			// assert -> verificación
			Assert.AreEqual(esperado, respuestaObtenida);
		}


		[TestMethod]
		public void DividirDosNumeros()
		{
			var dividendo = 10;
			var divisor = 5;
			var resultado = 2;

			var calculadora = new Calculadora();
			var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

			Assert.AreEqual(resultado, resultadoObtenido);
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DividirEntreCero()
		{
			var dividendo = 10;
			var divisor = 0;

			var calculadora = new Calculadora();
			var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

			// Assert.IsTrue(double.IsInfinity(resultadoObtenido);
		}

		[TestMethod]
		public void DividirCeroParaUnNumero()
		{
			var dividendo = 0;
			var divisor = 6;
			var resultado = 0;

			var calculadora = new Calculadora();
			var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

			Assert.AreEqual(resultado, resultadoObtenido);
		}

		[TestMethod]
		public void DividirDecimals()
		{
			var dividendo = 30;
			var divisor = 4;
			var resultado = 7.5;

			var calculadora = new Calculadora();
			var resultadoObtenido = calculadora.Dividir(dividendo, divisor);

			Assert.AreEqual(resultado, resultadoObtenido);
		}
		[TestMethod]
		public void LimitarDecimales()
		{
			var numeroDecimal = 1.61803398874989;
			var numeroLimitado = (Math.Round(numeroDecimal, 3));
			var espera = 1.618;

			var calculadora = new Calculadora();
			var resultado = calculadora.Limitar(numeroDecimal, numeroLimitado);

			Assert.AreEqual(espera, resultado);

		}

		[TestMethod]
		public void ObtenerUnNumeroConDosDecimales()
        {
			var numeroPiCon5Decimales = 3.14159;
			var numeroPiCon2Decimales = 3.14;

			var calculadora = new Calculadora();
			var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

			Assert.AreEqual(numeroPiCon2Decimales, resultado);

			
        }

		[TestMethod]
		public void ObtenerUnNumeroCon3Decimales()
		{
			var numeroPiConDecimales = 3.141592653589793238462643383;
			var numeroPiCon3Decimales = 3.141;

			var calculadora = new Calculadora();
			var resultado = calculadora.TomarTresDecimales(numeroPiConDecimales);

			Assert.AreEqual(numeroPiCon3Decimales, resultado);

		}

		[TestMethod]
		public void ObtenerNDecimales()
        {
			var numeroAureo = 1.61803398874989;
			var numeroDeDecimales = 5;
			var esperado = 1.61803;

			var calculadora = new Calculadora();
			var resultado = calculadora.TomarDecimales(numeroAureo,numeroDeDecimales);

			Assert.AreEqual(esperado, resultado);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ObtenerNDecimalesNegativos()
		{
			var numeroAureo = 1.61803398874989;
			var numeroDeDecimales = -5;

			var calculadora = new Calculadora();
			_ = calculadora.TomarDecimales(numeroAureo, numeroDeDecimales);
		}

		[TestMethod]
		[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
		public void AnadirEnteros()
		{
			var numeroEntero1 = 2;
			// int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
			var numeroEntero2 = -3;
			int esperado = 1;

			var calculadora = new Calculadora();
			int resultado = calculadora.AnadirEnteros(numeroEntero1, numeroEntero2);

			Assert.AreEqual(esperado, resultado);

		}



	}
}