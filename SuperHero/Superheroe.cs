using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class Superheroe : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }
        private string _enemigo;
        public string Enemigo {
            get { return this._enemigo; }
            set
            {
                if (this._enemigo != value)
                {
                    this._enemigo = value;
                    this.NotifyPropertyChanged("Enemigo");
                }
            }
        }

        private string _foto;
        public string Foto {
            get { return this._foto; }
            set
            {
                if (this._foto != value)
                {
                    this._foto = value;
                    this.NotifyPropertyChanged("Foto");
                }
            }
        }
        private bool _vengador;
        public bool Vengador {
            get { return this._vengador; }
            set
            {
                if (this._vengador != value)
                {
                    this._vengador = value;
                    this.NotifyPropertyChanged("Vengador");
                }
            }
        }


        public Superheroe()
        {
        }

        public Superheroe(string Nombre, string Enemigo, string Foto, bool Vengador)
        {
            this.Nombre = Nombre;
            this.Enemigo = Enemigo;
            this.Foto = Foto;
            this.Vengador = Vengador;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }
    }
}
