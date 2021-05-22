using SIGERRHH.Clases.Base_de_Datos;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace SIGERRHH.Interfaces
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsConexion cn = new ClsConexion();
            cn.consultaTablaDirecta($"insert into [tb_empleados] values({DPI},'{Nombre}',{Edad},'{Puesto}',{Salario},'{Fecha}','{Depto}'");
        }
    }
}
