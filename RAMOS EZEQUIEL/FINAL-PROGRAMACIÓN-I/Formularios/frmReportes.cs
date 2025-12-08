using FINAL_PROGRAMACIÓN_I.Utilidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    public partial class frmReportes : Form
    {
        public frmReportes(Form activeForm, DataTable actualTable)
        {
            InitializeComponent();

            switch (activeForm.Name)
            {
                case "frmClientes":
                    string rptPath = "C:\\Users\\ezequ\\Documents\\GitHub\\FINAL-PROGRAMACION-I-2025\\RAMOS EZEQUIEL\\FINAL-PROGRAMACIÓN-I\\bin\\Debug\\Reportes\\ClientesReporte.rdlc";
                    rptViewver.LocalReport.ReportPath = rptPath;
                    LocalReport reporte = rptViewver.LocalReport;
                    reporte.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("dsClientes", actualTable);
                    reporte.DataSources.Add(rds);
                    rptViewver.RefreshReport();
                    break;
                case "frmProductos":
                    string rptPath2 = "C:\\Users\\ezequ\\Documents\\GitHub\\FINAL-PROGRAMACION-I-2025\\RAMOS EZEQUIEL\\FINAL-PROGRAMACIÓN-I\\bin\\Debug\\Reportes\\ProductosReporte.rdlc";
                    rptViewver.LocalReport.ReportPath = rptPath2;
                    LocalReport reporte2 = rptViewver.LocalReport;
                    reporte2.DataSources.Clear();
                    ReportDataSource rds2 = new ReportDataSource("dsProductos", actualTable);
                    reporte2.DataSources.Add(rds2);
                    rptViewver.RefreshReport();
                    break;
                case "frmProveedores":
                    string rptPath3 = "C:\\Users\\ezequ\\Documents\\GitHub\\FINAL-PROGRAMACION-I-2025\\RAMOS EZEQUIEL\\FINAL-PROGRAMACIÓN-I\\bin\\Debug\\Reportes\\ProveedoresReporte.rdlc";
                    rptViewver.LocalReport.ReportPath = rptPath3;
                    LocalReport reporte3 = rptViewver.LocalReport;
                    reporte3.DataSources.Clear();
                    ReportDataSource rds3 = new ReportDataSource("dsProveedores", actualTable);
                    reporte3.DataSources.Add(rds3);
                    rptViewver.RefreshReport();
                    break;
                case "frmVentas":
                    string rptPath4 = "C:\\Users\\ezequ\\Documents\\GitHub\\FINAL-PROGRAMACION-I-2025\\RAMOS EZEQUIEL\\FINAL-PROGRAMACIÓN-I\\bin\\Debug\\Reportes\\VentaReporte.rdlc";
                    rptViewver.LocalReport.ReportPath = rptPath4;
                    LocalReport reporte4 = rptViewver.LocalReport;
                    reporte4.DataSources.Clear();
                    ReportDataSource rds4 = new ReportDataSource("DsVenta", actualTable);
                    reporte4.DataSources.Add(rds4);
                    rptViewver.RefreshReport();
                    break;
                case "frmConsultarVentas":
                    string rptPath5 = "C:\\Users\\ezequ\\Documents\\GitHub\\FINAL-PROGRAMACION-I-2025\\RAMOS EZEQUIEL\\FINAL-PROGRAMACIÓN-I\\bin\\Debug\\Reportes\\ConsultarVtaReporte.rdlc";
                    rptViewver.LocalReport.ReportPath = rptPath5;
                    LocalReport reporte5 = rptViewver.LocalReport;
                    reporte5.DataSources.Clear();
                    ReportDataSource rds5 = new ReportDataSource("DsVenta", actualTable);
                    reporte5.DataSources.Add(rds5);
                    rptViewver.RefreshReport();
                    break;
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            this.rptViewver.RefreshReport();
        }

        private void WinCtrlBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
