using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Clases;
using Clases.Util;

namespace ServicioWCF
{
    public class ServicioWCF : IServicioWCF
    {
        string strCon = ConfigurationManager.ConnectionStrings["ServicioWCF.Properties.Settings.dbProyectoAlfaConnectionString"].ConnectionString;

        private SqlConnection con;
        private SqlDataReader reader;
        private SqlCommand cmd;
        private SqlDataAdapter dAdap;

        public ServicioWCF()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
            }
            catch (Exception ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
            }
        }

        public cEmpleado LoginEmpleado(int ced, string pwd)
        {
            using (cmd = new SqlCommand("SELECT cedula, nombre, apellido, pwd FROM Empleados where cedula = @cedula AND pwd = @pwd", con))
            {
                cmd.Parameters.Add(new SqlParameter("@cedula", ced));
                cmd.Parameters.Add(new SqlParameter("@pwd", cEncrypt.GetMD5(pwd)));

                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                    return null;
                }

                if (reader.Read())
                {
                    int cedula_ = reader.GetInt32(0);
                    string nombre_ = reader.GetString(1);
                    string apellido_ = reader.GetString(2);

                    reader.Close();

                    return new cEmpleado(cedula_, nombre_, apellido_);
                }

                else
                    return null;
            }
        }

        public bool VerificarCliente(int ced)
        {
            bool passed;

            using (cmd = new SqlCommand("SELECT cedula FROM Clientes where cedula = @cedula", con))
            {
                cmd.Parameters.Add(new SqlParameter("@cedula", ced));

                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                    passed = false;
                }

                if (reader.Read())
                    passed = true;
                else
                    passed = false;

                reader.Close();

                return passed;
            }
        }

        public string CrearEmpleado(int ced, string nombre, string apellido, string pwd)
        {
            try
            {
                using (cmd = new SqlCommand("INSERT INTO Empleados VALUES (@cedula, @nombre, @apellido, @pwd)", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@cedula", ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@apellido", apellido));
                    cmd.Parameters.Add(new SqlParameter("@pwd", cEncrypt.GetMD5(pwd)));

                    reader = cmd.ExecuteReader();

                    return "1";
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public cEmpleado GetEmpleado(int ced)
        {
            using (cmd = new SqlCommand("SELECT cedula, nombre, apellido, pwd FROM Empleados where cedula = @cedula", con))
            {

                cmd.Parameters.Add(new SqlParameter("@cedula", ced));

                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                    return null;
                }

                if (reader.Read())
                    return new cEmpleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                else
                    return null;
            }
        }

        public string ModificarEmpleado(int ced, int nueva_ced, string nombre, string apellido, string pwd)
        {
            try
            {
                using (cmd = new SqlCommand("exec sp_ModificarEmpleado @cedula, @nueva_ced, @nombre, @apellido, @pwd", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@cedula", ced));
                    cmd.Parameters.Add(new SqlParameter("@nueva_ced", nueva_ced));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@apellido", apellido));
                    if (pwd != "")
                        cmd.Parameters.Add(new SqlParameter("@pwd", cEncrypt.GetMD5(pwd)));
                    else
                        cmd.Parameters.Add(new SqlParameter("@pwd", ""));

                    reader = cmd.ExecuteReader();

                    return "1";
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarProducto(int id, string nombre, string descripcion, int precio, int cantidad, int proveedor, int tipo)
        {
            try
            {
                if (id != 0)
                {
                    using (cmd = new SqlCommand("exec sp_ModificarProducto @id, @nombre, @descripcion, @precio, @cantidad, @proveedor, @tipo", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));
                        cmd.Parameters.Add(new SqlParameter("@precio", precio));
                        cmd.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                        cmd.Parameters.Add(new SqlParameter("@proveedor", proveedor));
                        cmd.Parameters.Add(new SqlParameter("@tipo", tipo));

                        reader = cmd.ExecuteReader();

                        return "modificado";
                    }
                }
                else
                {
                    using (cmd = new SqlCommand("exec sp_AgregarProducto @nombre, @descripcion, @precio, @cantidad, @proveedor, @tipo", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));
                        cmd.Parameters.Add(new SqlParameter("@precio", precio));
                        cmd.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                        cmd.Parameters.Add(new SqlParameter("@proveedor", proveedor));
                        cmd.Parameters.Add(new SqlParameter("@tipo", tipo));

                        reader = cmd.ExecuteReader();

                        return "creado";
                    }
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarProveedor(int id, string nombre, string rif, string dir_fiscal)
        {
            try
            {
                if (id != 0)
                {
                    using (cmd = new SqlCommand("exec sp_ModificarProveedor @id, @nombre, @rif, @dir_fiscal", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@rif", rif));
                        cmd.Parameters.Add(new SqlParameter("@dir_fiscal", dir_fiscal));

                        reader = cmd.ExecuteReader();

                        return "modificado";
                    }
                }
                else
                {
                    using (cmd = new SqlCommand("exec sp_AgregarProveedor @nombre, @rif, @dir_fiscal", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@rif", rif));
                        cmd.Parameters.Add(new SqlParameter("@dir_fiscal", dir_fiscal));

                        reader = cmd.ExecuteReader();

                        return "creado";
                    }
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarTipoProducto(int id, string descripcion)
        {
            try
            {
                if (id != 0)
                {
                    using (cmd = new SqlCommand("exec sp_ModificarTipoProducto @id, @descripcion", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));

                        reader = cmd.ExecuteReader();

                        return "modificado";
                    }
                }
                else
                {
                    using (cmd = new SqlCommand("exec sp_AgregarTipoProducto @descripcion", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@descripcion", descripcion));

                        reader = cmd.ExecuteReader();

                        return "creado";
                    }
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarCliente(int id, int cedula, string nombre, string apellido, string telefono)
        {
            try
            {
                if (id != 0)
                {
                    using (cmd = new SqlCommand("exec sp_ModificarCliente @id, @cedula, @nombre, @apellido, @telefono", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@cedula", cedula));
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido", apellido));
                        cmd.Parameters.Add(new SqlParameter("@telefono", telefono));

                        reader = cmd.ExecuteReader();

                        return "modificado";
                    }
                }
                else
                {
                    using (cmd = new SqlCommand("exec sp_AgregarCliente @cedula, @nombre, @apellido, @telefono", con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@cedula", cedula));
                        cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido", apellido));
                        cmd.Parameters.Add(new SqlParameter("@telefono", telefono));

                        reader = cmd.ExecuteReader();

                        return "creado";
                    }
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
        }

        public string EliminarProducto(int id)
        {
            try
            {
                using (cmd = new SqlCommand("delete from Productos where id = @id", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (var tran = con.BeginTransaction())
                    {
                        cmd.Transaction = tran;
                        reader = cmd.ExecuteReader();
                        tran.Commit();
                    }

                    return "1";
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarDeTabla(int id, string tabla)
        {
            try
            {
                using (cmd = new SqlCommand("delete from " + tabla + " where id = @id", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    reader = cmd.ExecuteReader();

                    return "1";
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable GetDataTable(string tabla)
        {
            DataTable dt = new DataTable();
            dt.TableName = tabla;

            try
            {
                using (cmd = new SqlCommand("select * from " + tabla, con))
                {
                    dAdap = new SqlDataAdapter(cmd);
                    dAdap.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
            }

            return dt;
        }

        public string AgregarFactura(int cedula)
        {
            string id;

            try
            {
                using (cmd = new SqlCommand("exec sp_AgregarFactura @cedula", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@cedula", cedula));

                    object obj = cmd.ExecuteScalar();

                    id = obj.ToString();

                    return id;
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AgregarDetalleFactura(int id, int id_producto, int cantidad, int precio)
        {
            try
            {
                using (cmd = new SqlCommand("exec sp_AgregarDetalleFactura @id, @id_producto, @cantidad, @precio", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@id_producto", id_producto));
                    cmd.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                    cmd.Parameters.Add(new SqlParameter("@precio", precio));

                    reader = cmd.ExecuteReader();

                    return "1";
                }
            }
            catch (SqlException ex)
            {
                cLogWriter log = new cLogWriter("ERROR: " + ex.ToString());
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
