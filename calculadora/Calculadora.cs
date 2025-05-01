namespace EspacioCalculadora
{
        
    public class Calculadora
    {
        private double dato;

        public double Resultado
        {
            get => dato;
        }


        public void Suma(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            dato /= termino;   
        }

        public void Limpiar()
        {
            dato = 0;
        }

        public double Dato
        {
            get => dato;
        }
    }
}
