using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{

    public class Equipo
    {
        ECategoria categoria;
        EDeporte deporte;
        Esexo sexo;
        int id;

        public Equipo()
        {

        }

        public Equipo(EDeporte deporte, ECategoria categoria, Esexo sexo)
        {
            this.categoria = categoria;
            this.deporte = deporte;
            this.sexo = sexo;
        }



        public Equipo(int id, EDeporte deporte, ECategoria categoria, Esexo sexo):this(deporte, categoria, sexo)
        {
            this.id = id;
        }
        public Equipo(ECategoria categoria, EDeporte deporte, Esexo sexo)
        {
            this.categoria = categoria;
            this.deporte = deporte;
            this.sexo = sexo;
        }

        public ECategoria Categoria
        {
            set { categoria = value; }
            get { return categoria; }
                
        }
        public EDeporte Deporte
        {
            set { deporte = value; }
            get { return deporte; }

        }
        public Esexo Sexo
        {
            set { sexo = value; }
            get { return sexo; }

        }

        public int Id
        {
            set { id = value; }
            get { return id; }

        }

        public override string ToString()
        {
            return $"Categoria: {this.categoria} | Deporte: {deporte} | Sexo: {sexo}";
        }

        public static bool operator +(List<Equipo> a, Equipo b)
        {
            foreach(Equipo item in a)
            {
                if (item == b)
                {
                    return false;
                }
            }
            a.Add(b);
            return true;
        }

        public static bool operator ==(Equipo a, Equipo b)
        {
            return (a.categoria == b.categoria && a.deporte == b.deporte && a.sexo == b.sexo);
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a==b);
        }


        public static explicit operator Equipo(int id)
        {
            foreach(Equipo item in Club.Equipos)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;
        }

        public static explicit operator int(Equipo equipo)
        {
            foreach (Equipo item in Club.Equipos)
            {
                if (equipo==item)
                {
                    return item.Id;
                }

            }
            return 0;
        }

    }
}
