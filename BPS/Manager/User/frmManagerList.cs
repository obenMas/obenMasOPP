using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Manager.User
{
    public partial class frmManagerList : Form
    {
        public string Notes = "";
        internal clsEmail email = new clsEmail();
        internal clsUser objUser = new clsUser();

        public frmManagerList()
        {
            InitializeComponent();
            PopulateRequest();
            PopulateStatus();
        }

        private void PopulateStatus()
        {
            List<clsStatus> lstStatus = new List<clsStatus>();
            lstStatus = clsStatus.getListByStatusGroupName("Solicitud");
            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);
        }

        private void PopulateRequest()
        {
            List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();
            lstRequestUser = clsRequestUser.getList();
            dgvRequestList.Rows.Clear();
            if (lstRequestUser.Count > 0)
            {
                for (int i = 0; i < lstRequestUser.Count; i++)
                {
                    dgvRequestList.Rows.Add();
                    dgvRequestList.Rows[i].Cells[clmrequestcodsec.Index].Value = lstRequestUser[i].codsec;
                    dgvRequestList.Rows[i].Cells[clmrequesttyperequest.Index].Value = lstRequestUser[i].name;
                    dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value = lstRequestUser[i].statusName;
                    dgvRequestList.Rows[i].Cells[clmrequestnumber.Index].Value = lstRequestUser[i].number;
                    dgvRequestList.Rows[i].Cells[clmrequestid.Index].Value = lstRequestUser[i].id;
                    dgvRequestList.Rows[i].Cells[clmrequestnotes.Index].Value = lstRequestUser[i].notes;
                    dgvRequestList.Rows[i].Cells[clmrequestdate.Index].Value = lstRequestUser[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvRequestList.Rows[i].Cells[clmrequestcreatedBy.Index].Value = lstRequestUser[i].lstUserCreator[0].firstName + " " + lstRequestUser[i].lstUserCreator[0].lastName;
                    dgvRequestList.Rows[i].Cells[clmrequestedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvRequestList.Rows[i].Cells[clmrequestdelete.Index].Value = global::BPS.Properties.Resources.cross;
                    dgvRequestList.Rows[i].Cells[clmrequestok.Index].Value = global::BPS.Properties.Resources.Up;
                    dgvRequestList.Rows[i].Cells[clmrequestnot.Index].Value = global::BPS.Properties.Resources.Down;
                    dgvRequestList.Rows[i].Cells[clmrequestview.Index].Value = global::BPS.Properties.Resources.eye;
                    dgvRequestList.Rows[i].Cells[clmrequestreport.Index].Value = global::BPS.Properties.Resources.report;
                    dgvRequestList.Rows[i].Cells[clmrequestcreatedByCodsec.Index].Value = lstRequestUser[i].lstUserCreator[0].codsec;
                    dgvRequestList.Rows[i].Cells[clmrequeststatusCodsec.Index].Value = lstRequestUser[i].statusCodsec;

                    if (clsGlobal.LoggedUser.codsec == 88 || clsGlobal.LoggedUser.codsec == 91 || clsGlobal.LoggedUser.codsec == 44)
                    {
                        dgvRequestList.Columns[clmrequestedit.Index].Visible = false;
                        dgvRequestList.Columns[clmrequestdelete.Index].Visible = false;
                    }
                    else
                    {
                        dgvRequestList.Columns[clmrequestok.Index].Visible = false;
                        dgvRequestList.Columns[clmrequestnot.Index].Visible = false;
                        dgvRequestList.Columns[clmrequestview.Index].Visible = false;
                    }
                }
                colorate();
            }
            else
            {
                dgvRequestList.Rows.Clear();
                MessageBox.Show("No existen datos para mostrar en lista", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvRequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clsRequestUser objResquestUser = new clsRequestUser();

                if (e.ColumnIndex == clmrequestok.Index)
                {
                    if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatusCodsec.Index].Value) == clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec)
                    {
                        if (MessageBox.Show("Está realmente seguro que desea aprobar la solictud selecionada?", "Solicitudes Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            if (clsRequestUser.isApproved(Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcodsec.Index].Value), true, Notes))
                            {
                                MessageBox.Show("Solicitud Aprobada Correctamente!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                objResquestUser.LoadByCodsec(Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcodsec.Index].Value));
                                SendMail("Aprobada",objResquestUser);
                                PopulateRequest();
                            }
                            else
                            {
                                MessageBox.Show("Error al procesar la información!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateRequest();
                            }
                        }
                        else
                            PopulateRequest();
                    }
                    else
                        MessageBox.Show("Usted no puede aprobar una solicitud si su estado es: " + dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatus.Index].Value, "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else if (e.ColumnIndex == clmrequestnot.Index)
                {
                    if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatusCodsec.Index].Value) == clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec)
                    {
                        if (MessageBox.Show("Está realmente seguro que desea aprobar la solictud selecionada?\r\nPor favor no olvide llenar el motivo por el cual no se aprueba la solicitud!!", "Solicitudes Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            frmCuttingOrderNotes winCuttingOrderNotes = new frmCuttingOrderNotes(this);
                            winCuttingOrderNotes.StartPosition = FormStartPosition.CenterScreen;
                            winCuttingOrderNotes.ShowDialog(this);
                            if (clsRequestUser.isApproved(Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcodsec.Index].Value), false, Notes))
                            {
                                MessageBox.Show("Solicitud Negada Correctamente!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                objResquestUser.LoadByCodsec(Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcodsec.Index].Value));
                                SendMail("Negada", objResquestUser);
                                PopulateRequest();
                            }
                            else
                            {
                                MessageBox.Show("Error al procesar la información!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateRequest();
                            }
                        }
                        else
                            PopulateRequest();
                    }
                    else
                        MessageBox.Show("Usted no puede aprobar una solicitud si su estado es: " + dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatus.Index].Value, "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else if (e.ColumnIndex == clmrequestview.Index)
                {
                }
                else if (e.ColumnIndex == clmrequestdelete.Index)
                {
                    if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcreatedByCodsec.Index].Value) == clsGlobal.LoggedUser.codsec)
                    {
                        if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatusCodsec.Index].Value) == clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec)
                        {
                            if (MessageBox.Show("Está realmente seguro que desea eliminar la solictud selecionada?", "Solicitudes Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                if (clsRequestUser.isDeleted(Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcodsec.Index].Value)))
                                {
                                    MessageBox.Show("Solicitud Eliminada Correctamente!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    PopulateRequest();
                                }
                                else
                                {
                                    MessageBox.Show("Error al procesar la información!!", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    PopulateRequest();
                                }
                            }
                            else
                                PopulateRequest();
                        }
                        else
                        {
                            MessageBox.Show("Usted no puede eliminar una orden si su estado es: " + dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatus.Index].Value, "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }

                    }
                    else
                        MessageBox.Show("Usted no puede modificar una solicitud que no haya creado. Solo el creador de la solicitud puede modificar o eliminar dicha solicitud", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else if (e.ColumnIndex == clmrequestedit.Index)
                {
                    if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequestcreatedByCodsec.Index].Value) == clsGlobal.LoggedUser.codsec)
                    {
                        if (Convert.ToInt32(dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatusCodsec.Index].Value) == clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec)
                        {
                            if (MessageBox.Show("Está realmente seguro que desea eliminar la solictud selecionada?", "Solicitudes Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                MessageBox.Show("Estamos trabajando en esta solución", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted no puede eliminar una orden si su estado es: " + dgvRequestList.Rows[e.RowIndex].Cells[clmrequeststatus.Index].Value, "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }

                    }
                    else
                        MessageBox.Show("Usted no puede modificar una solicitud que no haya creado. Solo el creador de la solicitud puede modificar o eliminar dicha solicitud", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void SendMail(string source, clsRequestUser objRequestUser)
        {
            try
            {
                

                switch (source)
                {
                    case "Aprobada":

                        email = new clsEmail();
                        objUser.load(objRequestUser.lstUserCreator[0].codsec);

                        //Add
                        email.subject = "Respuesta a la solicitud :" + objRequestUser.id.ToUpper();
                        email.from = "obenmas@boppdelecuador.com";
                        email.fromName = "OBEN MAS";

                        email.to.Add(objUser.mail);
                        email.toNames.Add(objUser.firstName + " " + objUser.lastName);
                        email.to.Add("eleiva@boppdelecuador.com");
                        email.toNames.Add("Erwin Leiva");

                        //Body

                        email.messageBody = "";
                        email.messageBody += "<p style = font-size: small; font-family: Calibri;>En hora buena su solicitud a sido &quot;APROBADA&quot;, en futuros días se comunicarán con usted desde el departamento se Sistemas sección ObenMas Developers.</p>";
                        email.messageBody += "<br />";
                        email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                        email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                        email.messageBody += "Información General de Solicitud</td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                        email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequestUser.id.ToUpper() + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                        email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequestUser.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequestUser.number + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Prioridad</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequestUser.priority + "</strong></td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Estado</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequestUser.statusName.ToUpper() + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Aprobación</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequestUser.isApprovedDate.ToString("dd/MM/yyyy HH:mm:ss") + "</strong></td></tr></table>";
                        email.messageBody += "<br />";
                        email.messageBody += "<p style = font-size: small; font-family: Calibri;> Saludos Cordiales,<br/>obenMas Software Production<br/>Bopp del Ecuador S.A.</p>";

                        email.smtpCredentials = new System.Net.NetworkCredential();

                        for (int i = 0; i < email.to.Count; i++)
                        {
                            try
                            {
                                string result = email.SendEmailAsync(email.to[i], email.toNames[i]);
                                Thread.Sleep(2000);
                            }
                            catch (Exception ex)
                            {
                                clsLog.addLog(ex, 3, "sent mail");
                                throw;
                            }
                        }

                        break;
                    case "Negada":
                        
                        email = new clsEmail();
                        objUser.load(objRequestUser.lstUserCreator[0].codsec);

                        //Add
                        email.subject = "Respuesta a la solicitud :" + objRequestUser.id.ToUpper();
                        email.from = "obenmas@boppdelecuador.com";
                        email.fromName = "OBEN MAS";

                        email.to.Add(objUser.mail);
                        email.toNames.Add(objUser.firstName + " " + objUser.lastName);
                        email.to.Add("eleiva@boppdelecuador.com");
                        email.toNames.Add("Erwin Leiva");

                        //Body

                        email.messageBody = "";
                        email.messageBody += "<p style = font-size: small; font-family: Calibri;>Uppss su solicitud a sido &quot;NEGADA&quot;, por gerencia con la siguiente resolución : <strong>" + objRequestUser.isApprovedNotes.ToUpper() + "</strong></p>";
                        email.messageBody += "<br />";
                        email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                        email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                        email.messageBody += "Información General de Solicitud</td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                        email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequestUser.id.ToUpper() + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                        email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequestUser.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequestUser.number + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Prioridad</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequestUser.priority + "</strong></td></tr>";
                        email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Estado</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequestUser.statusName.ToUpper() + "</strong></td>";
                        email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Negación</td>";
                        email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequestUser.isApprovedDate.ToString("dd/MM/yyyy HH:mm:ss") + "</strong></td></tr></table>";
                        email.messageBody += "<br />";
                        email.messageBody += "<p style = font-size: small; font-family: Calibri;> Saludos Cordiales,<br/>obenMas Software Production<br/>Bopp del Ecuador S.A.</p>";

                        email.smtpCredentials = new System.Net.NetworkCredential();

                        for (int i = 0; i < email.to.Count; i++)
                        {
                            try
                            {
                                string result = email.SendEmailAsync(email.to[i], email.toNames[i]);
                                Thread.Sleep(2000);
                            }
                            catch (Exception ex)
                            {
                                clsLog.addLog(ex, 3, "sent mail");
                                throw;
                            }
                        }

                        break;
                    case "Eliminada":
                        break;
                    case "Modificada":
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void colorate()
        {
            for (int i = 0; i < dgvRequestList.Rows.Count; i++)
            {
                if (dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value != null)
                {
                    switch (dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value.ToString())
                    {
                        case "Aprobada":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            break;
                        case "Activa":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.White;
                            break;
                        case "En proceso":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            break;
                        case "Completada":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            break;
                        case "Negada":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            break;
                        case "Eliminada":
                            for (int j = 0; j < dgvRequestList.Columns.Count; j++)
                                dgvRequestList.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                            break;
                        //case "Bajas":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                        //    break;
                        //case "Stock Perú":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(247, 202, 153);
                        //    break;
                        //case "Base para metalizar":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(241, 218, 239);
                        //    break;
                        default:
                            break;
                    }
                }
            }

        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            if (txtnumber.Focus() && !string.IsNullOrEmpty(txtnumber.Text))
            {
                txtid.Clear();
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Text = string.Empty;
                PopulateRequestByFilter(0);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Focus() && !string.IsNullOrEmpty(txtid.Text))
            {
                txtnumber.Clear();
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Text = string.Empty;
                PopulateRequestByFilter(0);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex > -1)
            {
                txtnumber.Clear();
                txtid.Clear();
                PopulateRequestByFilter(((clsStatus)cmbStatus.SelectedItem).codsec);
            }
        }

        private void PopulateRequestByFilter(int codsec)
        {
            if (codsec == 0)
            {
                if (string.IsNullOrEmpty(txtnumber.Text) && !string.IsNullOrEmpty(txtid.Text))
                {
                    List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();
                    lstRequestUser = clsRequestUser.getListByFilterID(txtid.Text);
                    dgvRequestList.Rows.Clear();
                    if (lstRequestUser.Count > 0)
                    {
                        for (int i = 0; i < lstRequestUser.Count; i++)
                        {
                            dgvRequestList.Rows.Add();
                            dgvRequestList.Rows[i].Cells[clmrequestcodsec.Index].Value = lstRequestUser[i].codsec;
                            dgvRequestList.Rows[i].Cells[clmrequesttyperequest.Index].Value = lstRequestUser[i].name;
                            dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value = lstRequestUser[i].statusName;
                            dgvRequestList.Rows[i].Cells[clmrequestnumber.Index].Value = lstRequestUser[i].number;
                            dgvRequestList.Rows[i].Cells[clmrequestid.Index].Value = lstRequestUser[i].id;
                            dgvRequestList.Rows[i].Cells[clmrequestnotes.Index].Value = lstRequestUser[i].notes;
                            dgvRequestList.Rows[i].Cells[clmrequestdate.Index].Value = lstRequestUser[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvRequestList.Rows[i].Cells[clmrequestcreatedBy.Index].Value = lstRequestUser[i].lstUserCreator[0].firstName + " " + lstRequestUser[i].lstUserCreator[0].lastName;
                            dgvRequestList.Rows[i].Cells[clmrequestedit.Index].Value = global::BPS.Properties.Resources.pencil;
                            dgvRequestList.Rows[i].Cells[clmrequestdelete.Index].Value = global::BPS.Properties.Resources.cross;
                            dgvRequestList.Rows[i].Cells[clmrequestok.Index].Value = global::BPS.Properties.Resources.Up;
                            dgvRequestList.Rows[i].Cells[clmrequestnot.Index].Value = global::BPS.Properties.Resources.Down;
                            dgvRequestList.Rows[i].Cells[clmrequestview.Index].Value = global::BPS.Properties.Resources.eye;
                            dgvRequestList.Rows[i].Cells[clmrequestreport.Index].Value = global::BPS.Properties.Resources.report;
                            dgvRequestList.Rows[i].Cells[clmrequestcreatedByCodsec.Index].Value = lstRequestUser[i].lstUserCreator[0].codsec;
                            dgvRequestList.Rows[i].Cells[clmrequeststatusCodsec.Index].Value = lstRequestUser[i].statusCodsec;

                            if (clsGlobal.LoggedUser.codsec == 88 || clsGlobal.LoggedUser.codsec == 91 || clsGlobal.LoggedUser.codsec == 44)
                            {
                                dgvRequestList.Columns[clmrequestedit.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestdelete.Index].Visible = false;
                            }
                            else
                            {
                                dgvRequestList.Columns[clmrequestok.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestnot.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestview.Index].Visible = false;
                            }
                        }
                        colorate();
                    }
                    else
                    {
                        dgvRequestList.Rows.Clear();
                        MessageBox.Show("No existen datos para mostrar en lista", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtid.Focus();
                    }
                }
                else if (string.IsNullOrEmpty(txtid.Text) && !string.IsNullOrEmpty(txtnumber.Text))
                {
                    List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();
                    lstRequestUser = clsRequestUser.getListByFilterNumber(txtnumber.Text);
                    dgvRequestList.Rows.Clear();
                    if (lstRequestUser.Count > 0)
                    {
                        for (int i = 0; i < lstRequestUser.Count; i++)
                        {
                            dgvRequestList.Rows.Add();
                            dgvRequestList.Rows[i].Cells[clmrequestcodsec.Index].Value = lstRequestUser[i].codsec;
                            dgvRequestList.Rows[i].Cells[clmrequesttyperequest.Index].Value = lstRequestUser[i].name;
                            dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value = lstRequestUser[i].statusName;
                            dgvRequestList.Rows[i].Cells[clmrequestnumber.Index].Value = lstRequestUser[i].number;
                            dgvRequestList.Rows[i].Cells[clmrequestid.Index].Value = lstRequestUser[i].id;
                            dgvRequestList.Rows[i].Cells[clmrequestnotes.Index].Value = lstRequestUser[i].notes;
                            dgvRequestList.Rows[i].Cells[clmrequestdate.Index].Value = lstRequestUser[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvRequestList.Rows[i].Cells[clmrequestcreatedBy.Index].Value = lstRequestUser[i].lstUserCreator[0].firstName + " " + lstRequestUser[i].lstUserCreator[0].lastName;
                            dgvRequestList.Rows[i].Cells[clmrequestedit.Index].Value = global::BPS.Properties.Resources.pencil;
                            dgvRequestList.Rows[i].Cells[clmrequestdelete.Index].Value = global::BPS.Properties.Resources.cross;
                            dgvRequestList.Rows[i].Cells[clmrequestok.Index].Value = global::BPS.Properties.Resources.Up;
                            dgvRequestList.Rows[i].Cells[clmrequestnot.Index].Value = global::BPS.Properties.Resources.Down;
                            dgvRequestList.Rows[i].Cells[clmrequestview.Index].Value = global::BPS.Properties.Resources.eye;
                            dgvRequestList.Rows[i].Cells[clmrequestreport.Index].Value = global::BPS.Properties.Resources.report;
                            dgvRequestList.Rows[i].Cells[clmrequestcreatedByCodsec.Index].Value = lstRequestUser[i].lstUserCreator[0].codsec;
                            dgvRequestList.Rows[i].Cells[clmrequeststatusCodsec.Index].Value = lstRequestUser[i].statusCodsec;

                            if (clsGlobal.LoggedUser.codsec == 88 || clsGlobal.LoggedUser.codsec == 91 || clsGlobal.LoggedUser.codsec == 44)
                            {
                                dgvRequestList.Columns[clmrequestedit.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestdelete.Index].Visible = false;
                            }
                            else
                            {
                                dgvRequestList.Columns[clmrequestok.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestnot.Index].Visible = false;
                                dgvRequestList.Columns[clmrequestview.Index].Visible = false;
                            }
                        }
                        colorate();
                    }
                    else
                    {
                        dgvRequestList.Rows.Clear();
                        MessageBox.Show("No existen datos para mostrar en lista", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtnumber.Focus();
                    }
                }
            }
            else
            {
                List<clsRequestUser> lstRequestUser = new List<clsRequestUser>();
                lstRequestUser = clsRequestUser.getListByFilterStatus(codsec);
                dgvRequestList.Rows.Clear();
                if (lstRequestUser.Count > 0)
                {
                    for (int i = 0; i < lstRequestUser.Count; i++)
                    {
                        dgvRequestList.Rows.Add();
                        dgvRequestList.Rows[i].Cells[clmrequestcodsec.Index].Value = lstRequestUser[i].codsec;
                        dgvRequestList.Rows[i].Cells[clmrequesttyperequest.Index].Value = lstRequestUser[i].name;
                        dgvRequestList.Rows[i].Cells[clmrequeststatus.Index].Value = lstRequestUser[i].statusName;
                        dgvRequestList.Rows[i].Cells[clmrequestnumber.Index].Value = lstRequestUser[i].number;
                        dgvRequestList.Rows[i].Cells[clmrequestid.Index].Value = lstRequestUser[i].id;
                        dgvRequestList.Rows[i].Cells[clmrequestnotes.Index].Value = lstRequestUser[i].notes;
                        dgvRequestList.Rows[i].Cells[clmrequestdate.Index].Value = lstRequestUser[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvRequestList.Rows[i].Cells[clmrequestcreatedBy.Index].Value = lstRequestUser[i].lstUserCreator[0].firstName + " " + lstRequestUser[i].lstUserCreator[0].lastName;
                        dgvRequestList.Rows[i].Cells[clmrequestedit.Index].Value = global::BPS.Properties.Resources.pencil;
                        dgvRequestList.Rows[i].Cells[clmrequestdelete.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvRequestList.Rows[i].Cells[clmrequestok.Index].Value = global::BPS.Properties.Resources.Up;
                        dgvRequestList.Rows[i].Cells[clmrequestnot.Index].Value = global::BPS.Properties.Resources.Down;
                        dgvRequestList.Rows[i].Cells[clmrequestview.Index].Value = global::BPS.Properties.Resources.eye;
                        dgvRequestList.Rows[i].Cells[clmrequestreport.Index].Value = global::BPS.Properties.Resources.report;
                        dgvRequestList.Rows[i].Cells[clmrequestcreatedByCodsec.Index].Value = lstRequestUser[i].lstUserCreator[0].codsec;
                        dgvRequestList.Rows[i].Cells[clmrequeststatusCodsec.Index].Value = lstRequestUser[i].statusCodsec;

                        if (clsGlobal.LoggedUser.codsec == 88 || clsGlobal.LoggedUser.codsec == 91 || clsGlobal.LoggedUser.codsec == 44)
                        {
                            dgvRequestList.Columns[clmrequestedit.Index].Visible = false;
                            dgvRequestList.Columns[clmrequestdelete.Index].Visible = false;
                        }
                        else
                        {
                            dgvRequestList.Columns[clmrequestok.Index].Visible = false;
                            dgvRequestList.Columns[clmrequestnot.Index].Visible = false;
                            dgvRequestList.Columns[clmrequestview.Index].Visible = false;
                        }
                    }
                    colorate();
                }
                else
                {
                    dgvRequestList.Rows.Clear();
                    MessageBox.Show("No existen datos para mostrar en lista", "Solicitudes Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateRequest();
        }
    }
}
