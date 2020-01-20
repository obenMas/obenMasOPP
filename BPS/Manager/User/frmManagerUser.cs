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
    public partial class frmManagerUser : Form
    {
        private int codsec = 0;
        public frmManagerUser()
        {
            InitializeComponent();
            PopulateTypeRequest();
        }

        private void PopulateTypeRequest()
        {
            List<clsTypeRequest> lstTypeRequest = clsTypeRequest.getListUserRequest();
            if (lstTypeRequest.Count > 0)
            {
                cmbType.Items.Clear();
                for (int i = 0; i < lstTypeRequest.Count; i++)
                    cmbType.Items.Add(lstTypeRequest[i]);
            }
        }

        public frmManagerUser(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            PopulateData(codsec);
        }

        private void PopulateData(int codsec)
        {
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex > -1)
            {
                switch (((clsTypeRequest)cmbType.SelectedItem).codsec)
                {
                    case 1:
                        tbcMain.TabPages.Clear();
                        tbcMain.TabPages.Insert(0, tbpAdd);
                        tbpAdd.Text = ((clsTypeRequest)cmbType.SelectedItem).name;
                        tbpAdd.ImageIndex = 0;
                        grpbDetails.Visible = true;
                        PopulatePriority();
                        PopulateRol();
                        break;

                    case 2:
                        tbcMain.TabPages.Clear();
                        tbcMain.TabPages.Insert(0, tbpReActive);
                        tbpReActive.Text = ((clsTypeRequest)cmbType.SelectedItem).name;
                        tbpReActive.ImageIndex = 2;
                        grpbDetails.Visible = true;
                        PopulatePriorityReactive();
                        PopulateUserReactive();
                        break;

                    case 3:
                        tbcMain.TabPages.Clear();
                        tbcMain.TabPages.Insert(0, tbpUpdate);
                        tbpUpdate.Text = ((clsTypeRequest)cmbType.SelectedItem).name;
                        tbpUpdate.ImageIndex = 2;
                        grpbDetails.Visible = true;
                        PopulatePriorityUpdate();
                        PopulateUserUpdate();
                        PopulateRolUpdate();
                        break;

                    case 4:
                        tbcMain.TabPages.Clear();
                        tbcMain.TabPages.Insert(0, tbpDelete);
                        tbpDelete.Text = ((clsTypeRequest)cmbType.SelectedItem).name;
                        tbpDelete.ImageIndex = 1;
                        grpbDetails.Visible = true;
                        PopulatePriorityDelete();
                        PopulateUserDelete();
                        break;

                    default:
                        break;
                }
            }
        }

        #region Created User

        private void PopulateRol()
        {
            List<clsRole> lstRole = clsRole.getList();
            if (lstRole.Count > 0)
            {
                cmbRol.Items.Clear();
                for (int i = 0; i < lstRole.Count; i++)
                    cmbRol.Items.Add(lstRole[i]);
            }
        }

        private void PopulatePriority()
        {
            List<clsTypeRequest> lstTypeRequest = clsTypeRequest.getListPriority();
            if (lstTypeRequest.Count > 0)
            {
                cmbPriority.Items.Clear();
                for (int i = 0; i < lstTypeRequest.Count; i++)
                    cmbPriority.Items.Add(lstTypeRequest[i]);
            }
        }

        private void btnAddUserSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    clsRequestUser objRequest = new clsRequestUser();
                    objRequest.fkType = ((clsTypeRequest)cmbType.SelectedItem).codsec;
                    objRequest.fkRol = ((clsRole)cmbRol.SelectedItem).codsec;
                    objRequest.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec;
                    objRequest.fkUser = clsGlobal.LoggedUser.codsec;
                    objRequest.number = clsRequestUser.getLastNumber();
                    objRequest.priority = ((clsTypeRequest)cmbPriority.SelectedItem).name;
                    objRequest.source = txtDepartament.Text;
                    objRequest.manager = txtManager.Text;
                    objRequest.firstName = txtFirstName.Text;
                    objRequest.lastName = txtLastName.Text;
                    objRequest.id = ((clsTypeRequest)cmbType.SelectedItem).id + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objRequest.number.ToString(), 5).ToString();
                    objRequest.notes = txtNotes.Text;
                    objRequest.isVisible = true;
                    if (objRequest.save())
                    {
                        MessageBox.Show("Solicitud Generada Correctamente!\r\nPor favor recuerde que su solicitud es: " + objRequest.id + "\r\nPor favor verifique el estado de su solicitud continuamente en el listado.\r\nMuy pronto el administrador responderá su solicitud!!\r\nSolicitud generada a las : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        clsGlobal.ClearForm(this);
                        SenderMail(objRequest);
                        grpbDetails.Visible = false;
                        cmbType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbPriority, ref label2, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbRol, ref label3, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtDepartament, ref label5, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtManager, ref label6, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtFirstName, ref label8, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLastName, ref label7, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtNotes, ref label9, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnAddUserExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Reactive User

        private void PopulatePriorityReactive()
        {
            List<clsTypeRequest> lstTypeRequest = clsTypeRequest.getListPriority();
            if (lstTypeRequest.Count > 0)
            {
                cmbReactivationPriority.Items.Clear();
                for (int i = 0; i < lstTypeRequest.Count; i++)
                    cmbReactivationPriority.Items.Add(lstTypeRequest[i]);
            }
        }

        private void PopulateUserReactive()
        {
            List<clsUser> lstUser = clsUser.getListExclude();
            if (lstUser.Count > 0)
            {
                cmbReactivationUser.Items.Clear();
                for (int i = 0; i < lstUser.Count; i++)
                    cmbReactivationUser.Items.Add(lstUser[i]);
            }
        }

        private void btnReactivationSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFormReactive())
                {
                    clsRequestUser objRequest = new clsRequestUser();
                    objRequest.fkType = ((clsTypeRequest)cmbType.SelectedItem).codsec;
                    objRequest.fkRol = ((clsUser)cmbReactivationUser.SelectedItem).fkRole;
                    objRequest.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec;
                    objRequest.fkUser = ((clsUser)cmbReactivationUser.SelectedItem).codsec;
                    objRequest.number = clsRequestUser.getLastNumber();
                    objRequest.priority = ((clsTypeRequest)cmbReactivationPriority.SelectedItem).name;
                    objRequest.source = "No identificado";
                    objRequest.manager = "No identificado";
                    objRequest.firstName = ((clsUser)cmbReactivationUser.SelectedItem).firstName;
                    objRequest.lastName = ((clsUser)cmbReactivationUser.SelectedItem).lastName;
                    objRequest.id = ((clsTypeRequest)cmbType.SelectedItem).id + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objRequest.number.ToString(), 5).ToString();
                    objRequest.notes = txtReactivationNotes.Text;
                    objRequest.isVisible = true;
                    if (objRequest.save())
                    {
                        MessageBox.Show("Solicitud Generada Correctamente!\r\nPor favor recuerde que su solicitud es: " + objRequest.id + "\r\nPor favor verifique el estado de su solicitud continuamente en el listado.\r\nMuy pronto el administrador responderá su solicitud!!\r\nSolicitud generada a las : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        clsGlobal.ClearForm(this);
                        SenderMail(objRequest);
                        grpbDetails.Visible = false;
                        cmbType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool validateFormReactive()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbReactivationPriority, ref label16, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbReactivationUser, ref label14, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtReactivationNotes, ref label14, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnReactivationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Modified User in Rol

        private void PopulateRolUpdate()
        {
            List<clsRole> lstRole = clsRole.getList();
            if (lstRole.Count > 0)
            {
                cmbUpdateRol.Items.Clear();
                for (int i = 0; i < lstRole.Count; i++)
                    cmbUpdateRol.Items.Add(lstRole[i]);
            }
        }

        private void PopulateUserUpdate()
        {
            List<clsUser> lstUser = clsUser.getList();
            if (lstUser.Count > 0)
            {
                cmbUpdateUser.Items.Clear();
                for (int i = 0; i < lstUser.Count; i++)
                    cmbUpdateUser.Items.Add(lstUser[i]);
            }
        }

        private void PopulatePriorityUpdate()
        {
            List<clsTypeRequest> lstTypeRequest = clsTypeRequest.getListPriority();
            if (lstTypeRequest.Count > 0)
            {
                cmbUpdatePriority.Items.Clear();
                for (int i = 0; i < lstTypeRequest.Count; i++)
                    cmbUpdatePriority.Items.Add(lstTypeRequest[i]);
            }
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFormUpdate())
                {
                    clsRequestUser objRequest = new clsRequestUser();
                    objRequest.fkType = ((clsTypeRequest)cmbType.SelectedItem).codsec;
                    objRequest.fkRol = ((clsRole)cmbUpdateRol.SelectedItem).codsec;
                    objRequest.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec;
                    objRequest.fkUser = ((clsUser)cmbUpdateUser.SelectedItem).codsec;
                    objRequest.number = clsRequestUser.getLastNumber();
                    objRequest.priority = ((clsTypeRequest)cmbUpdatePriority.SelectedItem).name;
                    objRequest.source = "Cambio de Rol dentro del sistema";
                    objRequest.manager = "Cambio de Rol dentro del sistema";
                    objRequest.firstName = ((clsUser)cmbUpdateUser.SelectedItem).firstName;
                    objRequest.lastName = ((clsUser)cmbUpdateUser.SelectedItem).lastName;
                    objRequest.id = ((clsTypeRequest)cmbType.SelectedItem).id + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objRequest.number.ToString(), 5).ToString();
                    objRequest.notes = txtUpdateNotes.Text;
                    objRequest.isVisible = true;
                    if (objRequest.save())
                    {
                        MessageBox.Show("Solicitud Generada Correctamente!\r\nPor favor recuerde que su solicitud es: " + objRequest.id + "\r\nPor favor verifique el estado de su solicitud continuamente en el listado.\r\nMuy pronto el administrador responderá su solicitud!!\r\nSolicitud generada a las : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        clsGlobal.ClearForm(this);
                        SenderMail(objRequest);
                        grpbDetails.Visible = false;
                        cmbType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool validateFormUpdate()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbUpdatePriority, ref label17, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUpdateUser, ref label15, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUpdateRol, ref label13, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtUpdateNotes, ref label13, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnUpdateExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Delete User

        private void PopulateUserDelete()
        {
            List<clsUser> lstUser = clsUser.getList();
            if (lstUser.Count > 0)
            {
                cmbDeleteUser.Items.Clear();
                for (int i = 0; i < lstUser.Count; i++)
                    cmbDeleteUser.Items.Add(lstUser[i]);
            }
        }

        private void PopulatePriorityDelete()
        {
            List<clsTypeRequest> lstTypeRequest = clsTypeRequest.getListPriority();
            if (lstTypeRequest.Count > 0)
            {
                cmbDeletePritority.Items.Clear();
                for (int i = 0; i < lstTypeRequest.Count; i++)
                    cmbDeletePritority.Items.Add(lstTypeRequest[i]);
            }
        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFormDelete())
                {
                    clsRequestUser objRequest = new clsRequestUser();
                    objRequest.fkType = ((clsTypeRequest)cmbType.SelectedItem).codsec;
                    objRequest.fkRol = ((clsUser)cmbDeleteUser.SelectedItem).fkRole;
                    objRequest.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Solicitud", "Activa").codsec;
                    objRequest.fkUser = ((clsUser)cmbDeleteUser.SelectedItem).codsec;
                    objRequest.number = clsRequestUser.getLastNumber();
                    objRequest.priority = ((clsTypeRequest)cmbDeletePritority.SelectedItem).name;
                    objRequest.source = "Eliminar usuario dentro del sistema";
                    objRequest.manager = "Eliminar usuario dentro del sistema";
                    objRequest.firstName = ((clsUser)cmbDeleteUser.SelectedItem).firstName;
                    objRequest.lastName = ((clsUser)cmbDeleteUser.SelectedItem).lastName;
                    objRequest.id = ((clsTypeRequest)cmbType.SelectedItem).id + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objRequest.number.ToString(), 5).ToString();
                    objRequest.notes = txtDeleteNotes.Text;
                    objRequest.isVisible = true;
                    if (objRequest.save())
                    {
                        MessageBox.Show("Solicitud Generada Correctamente!\r\nPor favor recuerde que su solicitud es: " + objRequest.id + "\r\nPor favor verifique el estado de su solicitud continuamente en el listado.\r\nMuy pronto el administrador responderá su solicitud!!\r\nSolicitud generada a las : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        clsGlobal.ClearForm(this);
                        SenderMail(objRequest);
                        grpbDetails.Visible = false;
                        cmbType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool validateFormDelete()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbDeletePritority, ref label11, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbDeleteUser, ref label10, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtDeleteNotes, ref label10, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnDeleteExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Mail

        private void SenderMail(clsRequestUser objRequest)
        {
            clsEmail email = new clsEmail();
            objRequest = new clsRequestUser();
            objRequest.LoadByCodsec(clsRequestUser.getLastSavedCodsec());
            if (objRequest.fkType == 1)
            {
                //Add
                email.subject = "Solicitud de " + objRequest.name + " " + objRequest.source; ;
                email.from = "obenmas@boppdelecuador.com";
                email.fromName = "OBEN MAS";
                email.to.Add("eleiva@boppdelecuador.com");
                email.toNames.Add("Erwin Leiva");
                email.to.Add("gpico@boppdelecuador.com");
                email.toNames.Add("Galo Pico");

                //Body
                email.messageBody = "";
                email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                email.messageBody += "SOLICITUD PARA " + objRequest.name.ToUpper() + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequest.id + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequest.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequest.number + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Estado</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequest.statusName + "</strong></td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Prioridad</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.priority + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Departamento</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.departament + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Solicitado Por</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.lstUserCreator[0].firstName + " " + objRequest.lstUserCreator[0].lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Usuario a Crear</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.firstName + " " + objRequest.lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Rol del Usuario a Crear</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.rolName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Descripción</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.notes + "</td></tr></table>";

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
            }
            else if (objRequest.fkType == 2)
            {
                //Reactivate
                email.subject = "Solicitud de " + objRequest.name + " " + objRequest.source; ;
                email.from = "obenmas@boppdelecuador.com";
                email.fromName = "OBEN MAS";
                email.to.Add("eleiva@boppdelecuador.com");
                email.toNames.Add("Erwin Leiva");
                email.to.Add("gpico@boppdelecuador.com");
                email.toNames.Add("Galo Pico");

                //Body
                email.messageBody = "";
                email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                email.messageBody += "SOLICITUD PARA " + objRequest.name.ToUpper() + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequest.id + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequest.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequest.number + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Estado</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequest.statusName + "</strong></td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Prioridad</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.priority + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Usuario a Reactivar</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.firstName + " " + objRequest.lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Rol a Reactivar</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.rolName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Solicitado Por</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.lstUserCreator[0].firstName + " " + objRequest.lstUserCreator[0].lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Descripción</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.notes + "</td></tr></table>";

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
            }
            else if (objRequest.fkType == 3)
            {
                //Update
                email.subject = "Solicitud de " + objRequest.name + " " + objRequest.source; ;
                email.from = "obenmas@boppdelecuador.com";
                email.fromName = "OBEN MAS";
                email.to.Add("eleiva@boppdelecuador.com");
                email.toNames.Add("Erwin Leiva");
                email.to.Add("gpico@boppdelecuador.com");
                email.toNames.Add("Galo Pico");

                //Body
                email.messageBody = "";
                email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                email.messageBody += "SOLICITUD PARA " + objRequest.name.ToUpper() + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequest.id + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequest.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequest.number + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Estado</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequest.statusName + "</strong></td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Prioridad</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.priority + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Usuario a Modificar</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.firstName + " " + objRequest.lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Rol de origen</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.lstUserMain[0].RoleName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Rol a Modificar</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.rolName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Solicitado Por</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.lstUserCreator[0].firstName + " " + objRequest.lstUserCreator[0].lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Descripción</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.notes + "</td></tr></table>";

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
            }
            else if (objRequest.fkType == 4)
            {
                //Delete
                email.subject = "Solicitud de " + objRequest.name + " " + objRequest.source; ;
                email.from = "obenmas@boppdelecuador.com";
                email.fromName = "OBEN MAS";
                email.to.Add("eleiva@boppdelecuador.com");
                email.toNames.Add("Erwin Leiva");
                email.to.Add("gpico@boppdelecuador.com");
                email.toNames.Add("Galo Pico");

                //Body
                email.messageBody = "";
                email.messageBody += "<table align=\"center\" cellpadding=\"2\" cellspacing=\"2\" style = \"width: 100%\" float: right;>";
                email.messageBody += "<tr><td colspan=\"4\" style =\"text-align: center; font-family: Calibri; font-weight: 700; font-size: large\">";
                email.messageBody += "SOLICITUD PARA " + objRequest.name.ToUpper() + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>Id</td>";
                email.messageBody += "<td style = font-size: large; font-family: Calibri; text-align: center; color: #FF9900; font-weight: 700;><strong>" + objRequest.id + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Fecha Elaboración</td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; color: #000099;>" + objRequest.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right>N°</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri;><strong>" + objRequest.number + "</strong></td>";
                email.messageBody += "<td style = width: 355px; font-weight: bold; font-size: medium; font-family: Calibri;>Estado</td>";
                email.messageBody += "<td style = font-size: medium; font-family: Calibri; color: #FF0000;><strong>" + objRequest.statusName + "</strong></td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Prioridad</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.priority + "</td></tr>";
                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium; text-align: right><strong>Usuario a Eliminar</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.firstName + " " + objRequest.lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Solicitado Por</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.lstUserCreator[0].firstName + " " + objRequest.lstUserCreator[0].lastName + "</td></tr>";

                email.messageBody += "<tr><td style = width: 152px; font-family: Calibri; font-weight: bold; font-size: medium;text-align: right><strong>Descripción</strong></td>";
                email.messageBody += "<td style = font-size: small; font-family: Calibri; colspan=\"3\">" + objRequest.notes + "</td></tr></table>";

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
            }
            else
            {
                // no data
            }


            

            //email.subject = "Solicitud de : PRUEBA";
            //email.from = "obenmas@boppdelecuador.com";
            //email.fromName = "OBEN MAS";

            //email.to.Add("eleiva@boppdelecuador.com");
            //email.toNames.Add("Erwin Leiva");

            //email.to.Add("gpico@boppdelecuador.com");
            //email.toNames.Add("Galo Pico");

            //email.to.Add("j_alam@boppdelecuador.com");
            //email.toNames.Add("Jhony Al Allam");



        }

        #endregion

    }
}
