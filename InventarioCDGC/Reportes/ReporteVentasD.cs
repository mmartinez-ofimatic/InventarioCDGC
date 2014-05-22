using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.Shared;

namespace InventarioCDGC.Reportes
{
    public partial class ReporteVentasD : Form
    {
        public ReporteVentasD()
        {
            InitializeComponent();
        }

        private void ReporteVentasD_Load(object sender, EventArgs e)
        {
            try
            {


             
                    //ReportAttributes rpAtt = new ReportAttributes();

                CrystalReportFactura1.Database.Tables["vwFacturas"].ApplyLogOnInfo(ConnectionInfo);
                //crystalReportViewer1.LogOnInfo.Add(ConnectionInfo);

                    ParameterField PID = new ParameterField();
                    PID.ParameterFieldName = "@IDVenta";
                    ParameterDiscreteValue myDiscreteValue = new ParameterDiscreteValue();
                    myDiscreteValue.Value = 14;
                    PID.CurrentValues.Add(myDiscreteValue);
                    crystalReportViewer1.ParameterFieldInfo.Clear();
                    crystalReportViewer1.ParameterFieldInfo.Add(PID);
                    crystalReportViewer1.Refresh();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrio un error al conectarse a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ReporteLogOn(out string server, out string database, out string user, out string password)
        {
            string[] valor = ConfigurationManager.ConnectionStrings["InventarioCDGCEntities1"].ConnectionString.Split(';');

            server = (valor[2].Split('"').GetValue(1).ToString()).Split('=').GetValue(1).ToString();
            database =(valor[3].Split('=').GetValue(1).ToString()).Trim();
            user = (valor[4].Split('=').GetValue(1).ToString()).Trim();
            password = (valor[5].Split('=').GetValue(1).ToString()).Trim();

            //server = (valor[0].Split('=').GetValue(1).ToString()).Trim();
            //database = (valor[1].Split('=').GetValue(1).ToString()).Trim();
            //user = (valor[2].Split('=').GetValue(1).ToString()).Trim();
            //password = (valor[3].Split('=').GetValue(1).ToString()).Trim();
        }

        public TableLogOnInfo ConnectionInfo
        {
            get
            {   //ojo Hay que asignarle el appconfig de IVR-CLI para que coja el Array de los Datos de la Conection (Credenciales).
                TableLogOnInfo info = new TableLogOnInfo();
                string[] valor = ConfigurationManager.ConnectionStrings["InventarioCDGCEntities1"].ConnectionString.Split(';');

                info.ConnectionInfo.UserID = (valor[4].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.Password = (valor[5].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.DatabaseName = (valor[3].Split('=').GetValue(1).ToString()).Trim();
                info.ConnectionInfo.ServerName = (valor[2].Split('"').GetValue(1).ToString()).Split('=').GetValue(1).ToString();

                return info;
            }
        }

        }
    
}
