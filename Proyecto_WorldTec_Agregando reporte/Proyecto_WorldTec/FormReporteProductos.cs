using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public partial class FormReporteProductos : Form
    {
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public FormReporteProductos()
        {
            InitializeComponent();
            var _productoBL = new ProductosBL();
            var bindingSource = new BindingSource();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();



        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteProductos));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1029, 731);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormReporteProductos
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 731);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteProductos";
            this.Text = "Reporte de Productos";
            this.Load += new System.EventHandler(this.FormReporteProductos_Load);
            this.ResumeLayout(false);

        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
