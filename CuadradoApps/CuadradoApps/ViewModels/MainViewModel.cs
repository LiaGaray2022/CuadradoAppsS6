using CuadradoApps.Models;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CuadradoApps.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double lado;
        private double lado2;
        private Cuadrado cuadrado;
        private string resultado;

        public double Lado
        {
            get => lado;
            set
            {
                if (lado != value)
                {
                    lado = value;
                    OnPropertyChanged(nameof(Lado));
                }
            }
        }

        public double Lado2
        {
            get => lado2;
            set
            {
                if (lado2 != value)
                {
                    lado2 = value;
                    OnPropertyChanged(nameof(Lado2));
                }
            }
        }

        public string Resultado
        {
            get => resultado;
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public ICommand CalcularCommand { get; }

        public MainViewModel()
        {
            CalcularCommand = new Command(Calcular);
        }

        private void Calcular()
        {
            cuadrado = new Cuadrado(Lado, Lado2);
            Resultado = $"Área: {cuadrado.Area}, Perímetro: {cuadrado.Perimetro}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
