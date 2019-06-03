using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Clases.Util;

namespace ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioWCF
    {
        [OperationContract]
        cEmpleado LoginEmpleado(int ced, string pwd);

        [OperationContract]
        string CrearEmpleado(int ced, string nombre, string apellido, string pwd);
        [OperationContract]
        cEmpleado GetEmpleado(int ced);
        [OperationContract]
        bool VerificarCliente(int ced);
        [OperationContract]
        string ModificarEmpleado(int ced, int nueva_ced, string nombre, string apellido, string pwd);
        [OperationContract]
        string EliminarProducto(int id);
        [OperationContract]
        string EliminarDeTabla(int id, string tabla);
        [OperationContract]
        string AlterarProducto(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo);
        [OperationContract]
        string AlterarProveedor(int id, string nombre, string rif, string dir_fiscal);
        [OperationContract]
        string AlterarCliente(int id, int cedula, string nombre, string apellido, string telefono);
        [OperationContract]
        string AlterarTipoProducto(int id, string descripcion);
        [OperationContract]
        string AgregarFactura(int cedula);
        [OperationContract]
        string AgregarDetalleFactura(int id, int id_producto, int cantidad, int precio);
        [OperationContract]
        DataTable GetDataTable(string tabla);
    }

    [DataContract]
    public class cEmpleado
    {
        [DataMember]
        public int Cedula { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }

        public cEmpleado(int ced, string nombre, string apellido)
        {
            Cedula = ced;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
