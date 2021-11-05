using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINQandSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;     //Mapeo, se debe crear el elemento con extension dbml
        public MainWindow()
        {
            InitializeComponent();
            //Conexion
            string miConexion = ConfigurationManager.ConnectionStrings["LINQandSql.Properties.settings.DataBaseLinqSql"].ConnectionString;
            //Instancia de mapeo
            dataContext = new DataClasses1DataContext(miConexion);

            // InsertarEmpresa();

            //InsertarEmpleado();

            //InsertarCargo();

            //InsertarCargoEmpleado();

            //ActualizaEmpleado();

            EliminarEmpleado();
        }

        public void InsertarEmpresa()
        {
            //dataContext.ExecuteCommand("delete from Empresa");   //Elimina los datos existentes antes de insertar los siguientes

            Empresa Google = new Empresa();

            Google.Nombre = "Google";

            dataContext.Empresas.InsertOnSubmit(Google);
            

            Empresa Microsoft = new Empresa();

            Microsoft.Nombre = "Microsoft";

            dataContext.Empresas.InsertOnSubmit(Microsoft);


            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.Empresas;

        }

        public void InsertarEmpleado()
        {
            Empresa Google = dataContext.Empresas.First(em => em.Nombre.Equals("Google"));

            Empresa Microsoft = dataContext.Empresas.First(em => em.Nombre.Equals("Microsoft"));


            List<Empleado> ListaEmpleado = new List<Empleado>();

            ListaEmpleado.Add(new Empleado { Nombre= "Juan", Apellido = "Acevedo", EmpresaId = Google.Id });

            ListaEmpleado.Add(new Empleado { Nombre = "Andres", Apellido = "Marin", EmpresaId = Microsoft.Id });

            ListaEmpleado.Add(new Empleado { Nombre = "Carolina", Apellido = "Munera", EmpresaId = Google.Id });

            ListaEmpleado.Add(new Empleado { Nombre = "Ana", Apellido = "Martinez", EmpresaId = Microsoft.Id });

            dataContext.Empleados.InsertAllOnSubmit(ListaEmpleado);

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.Empleados;

        }

        public void InsertarCargo()
        {
            dataContext.Cargos.InsertOnSubmit(new Cargo { NombreCargo = "Director" });

            dataContext.Cargos.InsertOnSubmit(new Cargo { NombreCargo = "Administrador" });


            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.Cargos;
        }

        public void InsertarCargoEmpleado()
        {/*
            //Empleados
            Empleado Juan = dataContext.Empleados.First(em => em.Nombre.Equals("Juan"));

            Empleado Andres = dataContext.Empleados.First(em => em.Nombre.Equals("Andres"));

            Empleado Carolina = dataContext.Empleados.First(em => em.Nombre.Equals("Carolina"));

            Empleado Ana = dataContext.Empleados.First(em => em.Nombre.Equals("Ana"));
            //Cargos
            Cargo Director = dataContext.Cargos.First(em => em.NombreCargo.Equals("Director"));

            Cargo Administrador = dataContext.Cargos.First(em => em.NombreCargo.Equals("Administrador"));

      
            //Cargo Empleado 1
            CargoEmpleado CargoJuan = new CargoEmpleado();

            CargoJuan.Empleado = Juan;

            CargoJuan.CargoId = Director.Id;

            //Cargo Empleado 2
            CargoEmpleado CargoAndres = new CargoEmpleado();

            CargoAndres.Empleado = Andres;

            CargoAndres.CargoId = Director.Id;

            //Cargo Empleado 3
            CargoEmpleado CargoCarolina = new CargoEmpleado();

            CargoCarolina.Empleado = Carolina;

            CargoCarolina.CargoId = Administrador.Id;

            //Cargo Empleado 4
            CargoEmpleado CargoAna = new CargoEmpleado();

            CargoAna.Empleado = Ana;

            CargoAna.CargoId = Administrador.Id;

            //Guardar Cambios
            dataContext.SubmitChanges();
            //Mostrar en pantalla
            principal.ItemsSource = dataContext.CargoEmpleados;
            

            //OTRO METODO MAS FACIL

            List<CargoEmpleado> ListaCargoEmpleado = new List<CargoEmpleado>();

            ListaCargoEmpleado.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 1 });

            ListaCargoEmpleado.Add(new CargoEmpleado { CargoId = 2, EmpleadoId = 2 });

            ListaCargoEmpleado.Add(new CargoEmpleado { CargoId = 2, EmpleadoId = 3 });

            dataContext.CargoEmpleados.InsertAllOnSubmit(ListaCargoEmpleado);

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.CargoEmpleados;
            

            //OTRO METODO
            Empleado Juan = dataContext.Empleados.First(em => em.Nombre.Equals("Juan"));

            Empleado Andres = dataContext.Empleados.First(em => em.Nombre.Equals("Andres"));

            Empleado Carolina = dataContext.Empleados.First(em => em.Nombre.Equals("Carolina"));

            Empleado Ana = dataContext.Empleados.First(em => em.Nombre.Equals("Ana"));

            Cargo Director = dataContext.Cargos.First(em => em.NombreCargo.Equals("Director"));

            Cargo Administrador = dataContext.Cargos.First(em => em.NombreCargo.Equals("Administrador"));

            List<CargoEmpleado> ListaCargoEmpleado = new List<CargoEmpleado>();

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = Juan, Cargo = Director });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = Andres, Cargo = Administrador });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = Carolina, Cargo = Director });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = Ana, Cargo = Administrador });

            dataContext.CargoEmpleados.InsertAllOnSubmit(ListaCargoEmpleado);

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.CargoEmpleados;

            */

            //OTRO METODO

            List<CargoEmpleado> ListaCargoEmpleado = new List<CargoEmpleado>();

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em => em.Nombre.Equals("Juan")), Cargo= dataContext.Cargos.First(em => em.NombreCargo.Equals("Director")) });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em => em.Nombre.Equals("Andres")), Cargo = dataContext.Cargos.First(em => em.NombreCargo.Equals("Administrador")) });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em => em.Nombre.Equals("Carolina")), Cargo = dataContext.Cargos.First(em => em.NombreCargo.Equals("Director")) });

            ListaCargoEmpleado.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em => em.Nombre.Equals("Ana")), Cargo = dataContext.Cargos.First(em => em.NombreCargo.Equals("Administrador")) });

            dataContext.CargoEmpleados.InsertAllOnSubmit(ListaCargoEmpleado);

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.CargoEmpleados;


        }

        public void ActualizaEmpleado()
        {
            Empleado Juan = dataContext.Empleados.First(em => em.Nombre.Equals("Juan"));

            Juan.Nombre = "Juan Fernando";

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.Empleados;

        }

        public void EliminarEmpleado()
        {
            Empleado Ana = dataContext.Empleados.First(em => em.Nombre.Equals("Ana"));

            dataContext.Empleados.DeleteOnSubmit(Ana);

            dataContext.SubmitChanges();

            principal.ItemsSource = dataContext.Empleados;


        }
    }
}
